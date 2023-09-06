using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Message : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text buttonText;
    public Text shopOwnerMessage;
    public Color32 messageOff;
    public Color32 messageOn;

    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = messageOn;
        Shooting.canMove = false;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = messageOff;

        Shooting.canMove = true;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        shopOwnerMessage.text = "Welcome to my store " + SaveScript.pname + "! How may I help fellow star monger?";
    }

    public void Message1()
    {
        shopOwnerMessage.text = "Xyronia Prime is homeworld of those filthy bloodthirsty Xyronians.. Damn them!";
    }
}
