  a  &          2018.3.0f2 ţ˙˙˙      ˙˙3$řĚuńě˛e+ Í=   ^          7  ˙˙˙˙         Ś ˛            Đ                 Ś                Ś                Ś #               Ś +               H 3   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ      	        Q  j     
        H <   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             Ő I   ˙˙˙˙       1  1  ˙˙˙˙    Ŕ    Ţ               H j  ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j              P             AssetMetaData guid data[0] data[1] data[2] data[3] pathName originalName labels assetStoreRef    ˙˙TMäb&H˛ăr˘3Ĺ!>   ß          7  ˙˙˙˙         Ś ˛               E            Ţ  #             . ,             5   a            Ţ  #             . ,              r            Ţ  #      	       . ,      
       H Ť ˙˙˙˙     1  1  ˙˙˙˙   @   Ţ             Q  j            ń  J   ˙˙˙˙       1  1  ˙˙˙˙        Ţ                j  ˙˙˙˙        \     ˙˙˙˙        H r   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H w   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H    ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             y 
              Ţ  #      !       . ,      "       Ő    ˙˙˙˙#       1  1  ˙˙˙˙$    Ŕ    Ţ      %          j  ˙˙˙˙&        H   ˙˙˙˙'       1  1  ˙˙˙˙(   @    Ţ      )        Q  j     *        y 
    +         Ţ  #      ,       . ,      -               .    @    ž ¨      /    @    Ţ  #      0       . ,      1       H ­   ˙˙˙˙2      1  1  ˙˙˙˙3   @    Ţ      4        Q  j     5        H ¸   ˙˙˙˙6      1  1  ˙˙˙˙7   @    Ţ      8        Q  j     9        H Ę   ˙˙˙˙:      1  1  ˙˙˙˙;   @    Ţ      <        Q  j     =      MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙         Ś ˛                E            Ţ               .              (   a            Ţ               .               r            Ţ        	       .       
       H Ť ˙˙˙˙     1  1  ˙˙˙˙   @   Ţ             Q  j            H ę ˙˙˙˙      1  1  ˙˙˙˙   @    Ţ              Q  j             ń  =   ˙˙˙˙      1  1  ˙˙˙˙       Ţ               j  ˙˙˙˙       H   ˙˙˙˙      1  1  ˙˙˙˙   @    Ţ              Q  j             y 
            Ţ               .              y Q               Ţ               .               Ţ  X      !        H i   ˙˙˙˙"      1  1  ˙˙˙˙#   @    Ţ      $        Q  j     %        H u   ˙˙˙˙&      1  1  ˙˙˙˙'   @    Ţ      (        Q  j     )      PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                x              x   P      ŕyŻ     Č   D                                                                                                                                                                                                                                                                                                                                                                                                                             $Î¨ÄMżąđoüĹWúO   Packages/com.unity.package-manager-ui/Editor/Sources/UI/PackageSearchToolbar.cs                                                                                                                                            PackageSearchToolbar­  using System;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace UnityEditor.PackageManager.UI
{
#if !UNITY_2018_3_OR_NEWER
    internal class PackageSearchToolbarFactory : UxmlFactory<PackageSearchToolbar>
    {
        protected override PackageSearchToolbar DoCreate(IUxmlAttributes bag, CreationContext cc)
        {
            return new PackageSearchToolbar();
        }
    }
#endif

    internal class PackageSearchToolbar : VisualElement
    {
#if UNITY_2018_3_OR_NEWER
        internal new class UxmlFactory : UxmlFactory<PackageSearchToolbar> { }
#endif
        private const string kPlaceHolder = "Search by package name, verified, preview or version number...";
        
        public event Action OnFocusChange = delegate { };
        public event Action<string> OnSearchChange = delegate { };
        
        private string searchText;
        private bool showingPlaceHolder;

        private readonly VisualElement root;

        public PackageSearchToolbar()
        {
            root = Resources.GetTemplate("PackageSearchToolbar.uxml");
            Add(root);
            root.StretchToParentSize();

            SearchTextField.value = searchText;
            SearchTextField.maxLength = 54;
            SearchCancelButton.clickable.clicked += SearchCancelButtonClick;
            
            RegisterCallback<AttachToPanelEvent>(OnEnterPanel);
            RegisterCallback<DetachFromPanelEvent>(OnLeavePanel);

            searchText = PackageSearchFilter.Instance.SearchText;
            
            if (string.IsNullOrEmpty(searchText))
            {
                showingPlaceHolder = true;
                SearchTextField.value = kPlaceHolder;
                SearchTextField.AddToClassList("placeholder");
            }
            else
            {
                showingPlaceHolder = false;
                SearchTextField.value = searchText;
                SearchTextField.RemoveFromClassList("placeholder");
            }
        }
        
        public void GrabFocus()
        {
            SearchTextField.Focus();
        }

        public new void SetEnabled(bool enable)
        {
            base.SetEnabled(enable);
            SearchTextField.SetEnabled(enable);
            SearchCancelButton.SetEnabled(enable);
        }

        private void OnSearchTextFieldChange(ChangeEvent<string> evt)
        {
            if (showingPlaceHolder && evt.newValue == kPlaceHolder)
                return;
            if (!string.IsNullOrEmpty(evt.newValue))
                SearchCancelButton.AddToClassList("on");
            else
                SearchCancelButton.RemoveFromClassList("on");

            searchText = evt.newValue;
            OnSearchChange(searchText);
        }

        private void OnSearchTextFieldFocus(FocusEvent evt)
        {
            if (showingPlaceHolder)
            {
                SearchTextField.value = string.Empty;
                SearchTextField.RemoveFromClassList("placeholder");
                showingPlaceHolder = false;
            }
        }

        private void OnSearchTextFieldFocusOut(FocusOutEvent evt)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                showingPlaceHolder = true;
                SearchTextField.AddToClassList("placeholder");
                SearchTextField.value = kPlaceHolder;
            }
        }

        private void SearchCancelButtonClick()
        {
            if (!string.IsNullOrEmpty(SearchTextField.value))
            {
                SearchTextField.value = string.Empty;
            }
            
            showingPlaceHolder = true;
            SearchTextField.AddToClassList("placeholder");
            SearchTextField.value = kPlaceHolder;
        }

        private void OnEnterPanel(AttachToPanelEvent evt)
        {
            SearchTextField.RegisterCallback<FocusEvent>(OnSearchTextFieldFocus);
            SearchTextField.RegisterCallback<FocusOutEvent>(OnSearchTextFieldFocusOut);
            SearchTextField.RegisterCallback<ChangeEvent<string>>(OnSearchTextFieldChange);
            SearchTextField.RegisterCallback<KeyDownEvent>(OnKeyDownShortcut);
        }

        private void OnLeavePanel(DetachFromPanelEvent evt)
        {
            SearchTextField.UnregisterCallback<FocusEvent>(OnSearchTextFieldFocus);
            SearchTextField.UnregisterCallback<FocusOutEvent>(OnSearchTextFieldFocusOut);
            SearchTextField.UnregisterCallback<ChangeEvent<string>>(OnSearchTextFieldChange);
            SearchTextField.UnregisterCallback<KeyDownEvent>(OnKeyDownShortcut);
        }

        private void OnKeyDownShortcut(KeyDownEvent evt)
        {
            if (evt.keyCode == KeyCode.Escape)
            {
                SearchCancelButtonClick();
                SearchCancelButton.Focus();
                evt.StopImmediatePropagation();
                return;
            }
            
            if (evt.keyCode == KeyCode.Tab)
            {
                OnFocusChange();
                evt.StopImmediatePropagation();
            }
        }
        private TextField SearchTextField { get { return root.Q<TextField>("searchTextField"); } }
        private Button SearchCancelButton { get { return root.Q<Button>("searchCancelButton"); } }
    }
}                          PackageSearchToolbar   UnityEditor.PackageManager.UI                                                                                                                                                                                                                                                                                                                                                                                                                                                                              