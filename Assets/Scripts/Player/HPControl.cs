    �]Z�y��N����r!��%   assets/scripts/dialog/dialogsystem.cs                                                                                                                                              DialogSystem�  using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System;

[ExecuteInEditMode]
public class DialogSystem : MonoBehaviour
{

    public GameObject player;
    public GameObject target;
    public string[] ListStatus = new string[4] { "Idle", "Dialog", "EndDialog", "Pause" };
    public string status;
    public byte[] StepDialog;
    [SerializeField] string[] text;
    [SerializeField] string[] text2;
    [SerializeField] int Questions_Count=0;
    [SerializeField] int Answers_Count=0;
    [SerializeField] string[] SimpleText;
    [SerializeField] string[] Questions;
    [SerializeField] string[] Answers;
    [SerializeField] float NeedRep;
    [SerializeField] float CurrRep;
    [SerializeField] float rep;
    [SerializeField] string path = "Assets/Text/text_xml.xml";
    [SerializeField] bool isStart;
    [SerializeField] XmlTextReader xmlAsset = new XmlTextReader("Assets/Text/text_xml.xml");

    void TextToArray()
    {
        FileStream fs = new FileStream(path, FileMode.Open);
        string content = "";
        using (StreamReader read = new StreamReader(fs, true))
        {
            content = read.ReadToEnd();
            string[] result = content.Split('\n');
               text = result;    
        }
        
    }
    void CountTagsIntoText()
    {
        Questions_Count = 0;
        Answers_Count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains("<q"))
            {
                Questions_Count++;
            }
            if (text[i].Contains("<a"))
            {
                Answers_Count++;
            }
            
        }
        StartArrays(Questions_Count, Answers_Count);

    }
    void StartArrays(int q, int a)
    {
        if (Questions_Count > 0 || Answers_Count > 0)
        {
            Questions = new string[q];
             Answers = new string[a];
        }
        else print("Questions_Count < 0 or Answers_Count < 0");
    } 
    //void TextToOtherArrays()
    //{
 