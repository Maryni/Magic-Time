using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDialogSystem
{
    string[] ListStatus { get; set; }
    string status { get; set; }
    void GetStatus();
    void CheckStatus();
    void GetText();
    void GetDialogStep();
    void GetReputation();

}
