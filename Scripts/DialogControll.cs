using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogControll : MonoBehaviour {

    public Text dialogText; 
    public string totalText; //Texto a ser escrito na tela
    public int indiceAtual; // Palavra atual do texto que será escrito na tela
    public float velocidadeTexto; //Intervalo de escrita de cada letra
    public float contaTempo;
    public bool inDialog; //Controle de dialogo

    public JsonDialogReader jsonDialogReader = new JsonDialogReader();


    void Start()
    {
    }

    void Update()
    {
        if (!inDialog)
        {
        }
        else
        {
            contaTempo += Time.deltaTime;
            if(contaTempo > velocidadeTexto)
            {
                if (indiceAtual < totalText.Length)
                {
                    dialogText.text += totalText[indiceAtual];
                    indiceAtual++;
                    contaTempo = 0;
                }
                else
                {
                    inDialog = false;
                    contaTempo = 0;
                    indiceAtual = 0;
                }              
            }
        }
    }

	public void callDialog(string name, int index)
    {
        dialogText.text = "";
        indiceAtual = 0;
        contaTempo = 0;
        totalText = jsonDialogReader.getJsonDialog(name, index );
        inDialog = true;
    }
}

