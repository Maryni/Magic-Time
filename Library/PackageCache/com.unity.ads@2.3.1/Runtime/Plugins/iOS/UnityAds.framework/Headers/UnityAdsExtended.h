-------------------------------------------------------------------------------
----
----	OVERVIEW "Tutorial_2\A_Character_2"
----
----	GET CHAR OVERVIEW INFO
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

	SetState("#Player", STATE_CUTSCENE, true