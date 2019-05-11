using UnityEngine;
using System.Collections;
using System.Xml.Linq;
using System.Collections.Generic;

public class DialogInitiolisation
{
    public int id_text;
    public int steps;
    public string NPC_Name = string.Empty;
    public bool CanBeMain;
    public string type = string.Empty;
    public string StyleDialog = string.Empty;
    public string TypeActivePerson = string.Empty;
    public List<DialogInitiolisation> list = new List<DialogInitiolisation>();
}
