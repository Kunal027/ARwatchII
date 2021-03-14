using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clolorSelect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void w1colorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName == "BlackButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myClolor);
            band1.color = myClolor;

        }
        else if(buttonName == "BlueButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#103B90", out myClolor);
            band1.color = myClolor;
        }
    }

    public void w2colorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "BlackButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myClolor);
            band2.color = myClolor;
        }
        else if(buttonName == "RedButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myClolor);
            band2.color = myClolor;
        }
         
    }

    public void w3colorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "BlackButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out myClolor);
            band3.color = myClolor;
        }
        else if (buttonName == "SilverButton")
        {
            Color myClolor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myClolor);
            band3.color = myClolor;
        }

    }
}
