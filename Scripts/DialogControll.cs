using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogControll : MonoBehaviour {

    public Text DialogText; 
    public string TotalText; //Texto a ser escrito na tela
    public int CurrentIndex; // Palavra atual do texto que será escrito na tela
    public float TextVelocity; //Intervalo de escrita de cada letra
    public float TimeCout;
    public bool InDialog; //Controle de dialogo

    public JsonDialogReader jsonDialogReader = new JsonDialogReader();


    void Start()
    {
    }

    void Update()
    {
        if (!InDialog)
        {
        }
        else
        {
            TimeCout += Time.deltaTime;
            if(TimeCout > TextVelocity)
            {
                if (CurrentIndex < TotalText.Length)
                {
                    DialogText.text += TotalText[CurrentIndex];
                    CurrentIndex++;
                    TimeCout = 0;
                }
                else
                {
                    InDialog = false;
                    TimeCout = 0;
                    CurrentIndex = 0;
                }              
            }
        }
    }

	public void callDialog(string name, int index)
    {
        DialogText.text = "";
        CurrentIndex = 0;
        TimeCout = 0;
        TotalText = jsonDialogReader.getJsonDialog(name, index );
        InDialog = true;
    }
}

