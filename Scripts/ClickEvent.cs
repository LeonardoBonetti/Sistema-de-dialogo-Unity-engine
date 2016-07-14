using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour {

    //your button
    public Button b;

    //control the value to pass to event as you need
    public int index;
    public string name;

    void Start()
    {
        b = this.GetComponent<Button>();
        //register new event to onclick with the variables that control your args
        b.onClick.AddListener(() => GameObject.Find("DialogControll").GetComponent<DialogControll>().callDialog(name,index));
    }


}
