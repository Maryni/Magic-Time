using System;
using System.Linq;
using System.Security.Cryptography;
using UnityEditor.Connect;
using UnityEditor.Web;
using UnityEngine;

#if UNITY_2019_1_OR_NEWER
using UnityEngine.UIElements;
#else
using UnityEngine.Experimental.UIElements;
using UnityEngine.Experimental.UIElements.StyleEnums;
#endif

namespace UnityEditor.Collaboration
{
    internal class CollabHistoryItem : VisualElement
    {
        public static RevisionAction s_OnRestore;
        public static RevisionAction s_OnGoBack;
        public static RevisionAction s_OnUpdate;
        public static ShowBuildAction s_OnShowBuild;
        public static Action s_OnShowServices;

        private readonly string m_RevisionId;
        private readonly string m_FullDescription;
        private readonly DateTime m_TimeStamp;
        private readonly Button m_Button;
        private readonly HistoryProgressSpinner m_ProgressSpinner;
        private VisualElement m_ActionsTray;
        private VisualElement m_Details;
        private Label m_Description;
        private Label m_TimeAgo;
        private readonly Button m_ExpandCollapseButton;
        private bool m_Expanded;

        private const int kMaxDescriptionChars = 500;

        public bool RevisionActionsEnabled
        {
            set
            {
                m_Button.SetEnabled(value);
            }
        }

        public DateTime timeStamp
        {
            get { return m_TimeStamp; }
        }

        public CollabHistoryItem(RevisionData data)
        {
            m_RevisionId = data.id;
            m_TimeStamp = data.timeStamp;
            name = "HistoryItem";
            m_ActionsTray = new VisualElement {name = "HistoryItemActionsTray"};
            m_ProgressSpinner = new HistoryProgressSpinner();
            m_Details = new VisualElement {name = "HistoryDetail"};
            var author = new Label(data.authorName) {name = "Author"};
            m_TimeAgo = new Label(TimeAgo.GetString(m_TimeStamp));
            m_FullDescription = data.comment;
            var shouldTruncate = ShouldTruncateDescription(m_FullDescription);
            if (shouldTruncate)
            {
                m_Description = new Label(GetTruncatedDescription(m_FullDescription));
            }
            else
            {
                m_Description = new Label(m_FullDescription);
            }
            m_Description.name = "RevisionDescription";
            var dropdown = new CollabHistoryDropDown(data.changes, data.changesTotal, data.changesTruncated, data.id);
            if (data.current)
            {
                m_Button = new Button(Restore) {name = "ActionButton", text = "Restore"};
            }
            else if (data.obtained)
            {
                m_Button = new Button(GoBackTo) {name = "ActionButton", text = "Go back to..."};
            }
            else
            {
                m_Button = new Button(UpdateTo) {name = "ActionButton", text = "Update"};
            }
            m_Button.SetEnabled(data.enabled);
            m_ProgressSpinner.ProgressEnabled = data.inProgress;

            m_ActionsTray.Add(m_ProgressSpinner);
            m_ActionsTray.Add(m_Button);

            m_Details.Add(author);
            m_Details.Add(m_TimeAgo);
            m_Details.Add(m_Description);

            if (shouldTruncate)
            {
                m_ExpandCollapseButton = new Button(ToggleDescription) { name = "ToggleDescription", text = "Show More" };
                m_Details.Add(m_ExpandCollapseButton);
            }

            if (data.buildState != BuildState.None)
            {
                BuildStatusButton buildButton;
                if (data.buildState == BuildState.Configure)
                    buildButton = new BuildStatusButton(ShowServicePage);
                else
                    buildButton = new BuildStatusButton(ShowBuildForCommit, data.buildState, data.buildFailures);

                m_Details.Add(buildButton);
            }

            m_Details.Add(m_ActionsTray);
            m_Details.Add(dropdown);

            Add(m_Details);

            this.schedule.Execute(UpdateTimeAgo).Every(1000 * 20);
        }

        public static void SetUpCallbacks(RevisionAction Restore, RevisionAction GoBack, RevisionAction Update)
        {
            s_OnRestore = Restore;
            s_OnGoBack = GoBack;
            s_OnUpdate = Update;
        }

        public void SetInProgressStatus(string revisionIdInProgress)
        {
            if (String.IsNullOrEmpty(revisionIdInProgress))
            {
                m_Button.SetEnabled(true);
                m_ProgressSpinner.ProgressEnabled = false;
            }
            else
            {
                m_Button.SetEnabled(false);
                if (m_RevisionId.Equals(revisionIdInProgress))
                {
                    m_ProgressSpinner.ProgressEnabled = true;
                }
            }
        }

        void ShowBuildForCommit()
        {
            CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "ShowBuild");
            if (s_OnShowBuild != null)
            {
                s_OnShowBuild(m_RevisionId);
            }
        }

        void ShowServicePage()
        {
            CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "ShowServices");
            if (s_OnShowServices != null)
            {
                s_OnShowServices();
            }
        }

        void Restore()
        {
            CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "Restore");
            if (s_OnRestore != null)
            {
                s_OnRestore(m_RevisionId, false);
            }
        }

        void GoBackTo()
        {
            CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "GoBackTo");
            if (s_OnGoBack != null)
            {
                s_OnGoBack(m_RevisionId, false);
            }
        }

        void UpdateTo()
        {
            CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "Update");
            if (s_OnUpdate != null)
            {
                s_OnUpdate(m_RevisionId, true);
            }
        }

        void UpdateTimeAgo()
        {
            m_TimeAgo.text = TimeAgo.GetString(m_TimeStamp);
        }

        bool ShouldTruncateDescription(string description)
        {
            return description.Contains(Environment.NewLine) || description.Length > kMaxDescriptionChars;
        }

        string GetTruncatedDescription(string description)
        {
            string result = description.Contains(Environment.NewLine) ?
                description.Substring(0, description.IndexOf(Environment.NewLine)) : description;
            if (result.Length > kMaxDescriptionChars)
            {
                result = result.Substring(0, kMaxDescriptionChars) + "...";
            }
            return result;
        }

        void ToggleDescription()
        {
            if (m_Expanded)
            {
                CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "CollapseDescription");
                m_Expanded = false;
                m_ExpandCollapseButton.text = "Show More";
                m_Description.text = GetTruncatedDescription(m_FullDescription);
            }
            else
            {
                CollabAnalytics.SendUserAction(CollabAnalytics.historyCategoryString, "ExpandDescription");
                m_Expanded = true;
                m_ExpandCollapseButton.text = "Show Less";
                m_Description.text = m_FullDescription;
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     �PNG

   IHDR  y   D   d�E�   	pHYs     ��  
OiCCPPhotoshop ICC profile  xڝSgTS�=���BK���KoR RB���&*!	J�!��Q�EEȠ�����Q,�
��!���������{�kּ������>�����H3Q5��B�������.@�
$p �d!s�# �~<<+"�� x� �M��0���B�\���t�8K� @z�B� @F���&S � `�cb� P- `'�� ����{ [�!��  e�D h; ��V�E X0 fK�9 �- 0IWfH �� ���  0Q��) { `�##x �� F�W<�+��*  x��<�$9E�[-qWW.(�I+6aa�@.�y�2�4���  ������x����6��_-��"bb���ϫp@  �t~��,/��;�m��%�h^�u��f�@� ���W�p�~<<E���������J�B[a�W}�g�_�W�l�~<�����$�2]�G�����L�ϒ	�b��G�����"�Ib�X*�Qq�D���2�"�B�)�%��d��,�>�5 �j>{�-�]c�K'Xt���  �o��(�h���w��?�G�% �fI�q  ^D$.Tʳ?�  D��*�A��,�����`6�B$��BB
d�r`)��B(�Ͱ*`/�@4�Qh��p.�U�=p�a��(��	A�a!ڈb�X#����!�H�$ ɈQ"K�5H1R�T UH�=r9�\F��;� 2����G1���Q=��C��7�F��dt1�����r�=�6��Ыhڏ>C�0��3�l0.��B�8,	�c˱"����V����cϱw�E�	6wB aAHXLXN�H� $4�	7	�Q�'"��K�&���b21�XH,#��/{�C�7$�C2'��I��T��F�nR#�,��4H#���dk�9�, +ȅ����3��!�[
�b@q��S�(R�jJ��4�e�2AU��Rݨ�T5�ZB���R�Q��4u�9̓IK�����hh�i��t�ݕN��W���G���w��ǈg(�gw��L�Ӌ�T071���oUX*�*|��
�J�&�*/T����ުU�U�T��^S}�FU3S�	Ԗ�U��P�SSg�;���g�oT?�~Y��Y�L�OC�Q��_�� c�x,!k��u�5�&���|v*�����=���9C3J3W�R�f?�q��tN	�(���~���)�)�4L�1e\k����X�H�Q�G�6������E�Y��A�J'\'Gg����S�Sݧ
�M=:��.�k���Dw�n��^��Lo��y���}/�T�m���GX�$��<�5qo</���QC]�@C�a�a�ᄑ��<��F�F�i�\�$�m�mƣ&&!&KM�M�RM��)�;L;L���͢�֙5�=1�2��כ߷`ZxZ,����eI��Z�Yn�Z9Y�XUZ]�F���%ֻ�����N�N���gð�ɶ�����ۮ�m�}agbg�Ů��}�}��=���Z~s�r:V:ޚΜ�?}����/gX���3��)�i�S��Ggg�s�󈋉K��.�>.���Ƚ�Jt�q]�z���������ۯ�6�i�ܟ�4�)�Y3s���C�Q��?��0k߬~OCO�g��#/c/�W�װ��w��a�>�>r��>�<7�2�Y_�7��ȷ�O�o�_��C#�d�z�� ��%g��A�[��z|!��?:�e����A���AA�������!h�쐭!��Α�i�P~���a�a��~'���W�?�p�X�1�5w��Cs�D�D�Dޛg1O9�-J5*>�.j<�7�4�?�.fY��X�XIlK9.*�6nl��������{�/�]py�����.,:�@L�N8��A*��%�w%�
y��g"/�6ш�C\*N�H*Mz�쑼5y$�3�,幄'���LLݛ:��v m2=:�1����qB�!M��g�g�fvˬe����n��/��k���Y-
�B��TZ(�*�geWf�͉�9���+��̳�ې7�����ᒶ��KW-X潬j9�<qy�
�+�V�<���*m�O��W��~�&zMk�^�ʂ��k�U
�}����]OX/Yߵa���>������(�x��oʿ�ܔ���Ĺd�f�f���-�[����n�ڴ�V����E�/��(ۻ��C���<��e����;?T�T�T�T6��ݵa��n��{��4���[���>ɾ�UUM�f�e�I���?�������m]�Nmq����#�׹���=TR��+�G�����w-6U����#pDy���	��:�v�{���vg/jB��F�S��[b[�O�>����z�G��4<Yy