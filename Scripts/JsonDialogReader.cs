using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using System.IO;

public class JsonDialogReader
{
    string str;
    JSONNode json;


    string Read()
    {
        string filePath = (Application.dataPath + "/dialogos.json"); 
        StreamReader sr = new StreamReader(filePath);
        string content = sr.ReadToEnd();
        sr.Close();
        return content;
    }


    public string getJsonDialog(string name, int index)
    {
      
        str = Read();
        json = JSON.Parse(str);
        return json[name]["dialogs"][index]["content"];
    }



}

