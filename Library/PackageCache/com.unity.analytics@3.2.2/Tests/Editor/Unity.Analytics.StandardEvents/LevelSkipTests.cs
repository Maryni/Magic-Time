-------------------------------------------------------------------------------
----
----	OVERVIEW "_Tutorial_1\Intro1"
----
----	
----
----	1. function Bind
----
----	2. Bind / Start the next Quest(s)
----
-------------------------------------------------------------------------------


-------------------------------------------------------------------------------
----	1. function Bind
-------------------------------------------------------------------------------
function Bind()
	return true
end

function CheckStart()
	return true
end

function Start()
-------------------------------------------------------------------------------
----	Disable the HUD measure >BuildBuilding<
-------------------------------------------------------------------------------
	HudEnableElement("BuildBuilding", false)
-------------------------------------------------------------------------------
	SetMainQuestTitle("Tutorial", "@L_TUTORIAL_CHAPTER_1_NAME")
	SetMainQuestDescription("Tutorial","@L_TUTORIAL_CHAPTER_1_WELCOME")	

	SetMainQuest("Tutorial")
	SetQuestTitle("@L_TUTORIAL_CHAPTER_1_NAME")
	SetQuestDescription("@L_TUTORIAL_CHAPTER_1_WELCOME",true)	
-------------------------------------------------------------------------------
----	Show the intro text of the chapter
-------------------------------------------------------------------------------
	SetState("#Player", STATE_CUTSCENE, true)
	
	Sleep(3)
	
	MsgNews("#Player",0,"@B[MB_OK,@L_GENERAL_BUTTONS_OK]@P","","default",-1,"@L_TUTORIAL_CHAPTER_1_NAME","@L_TUTORIAL_CHAPTER_1_NOSPEECHINTRO")
	
	ShowTutorialBoxNoWait(60, 600, 500, 135, 1, LEFTUPPER, "@L_TUTORIAL_CHAPTER_1_NAME","@L_TUTORIAL_CHAPTER_1_HINT",  "")

	MsgQuest("#Player",0,"MB_OK","@L_TUTORIAL_CHAPTER_1_NAME","@L_TUTORIAL_CHAPTER_1_WELCOME")
	
	ShowTutorialBoxNoWait(970, 710, 400, 135, 1