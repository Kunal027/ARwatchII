using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject watchWindow1;
    public GameObject watchWindow2;
    public GameObject watchWindow3;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    

    void Start()
    {
        w1WindowAnimation = watchWindow1.GetComponent<Animation>();
        w2WindowAnimation = watchWindow2.GetComponent<Animation>();
        w3WindowAnimation = watchWindow3.GetComponent<Animation>();
    }

    
    void Update()
    {
        
    }

    public void Watch1ButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowAnimation["W1Anim"].speed = 1;
        w1WindowAnimation.Play();
    }
    
    public void Watch2ButtonClicked()
    {
        watchModel2.SetActive(true);
        watchModel1.SetActive(false);
        watchModel3.SetActive(false);
        w2WindowAnimation["W2Anim"].speed = 1;
        w2WindowAnimation.Play();
    }
    
    public void Watch3ButtonClicked()
    {
        watchModel3.SetActive(true);
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        w3WindowAnimation["W3Anim"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if(ButtonName == "W1close")
        {
            w1WindowAnimation["W1Anim"].speed = -1;
            w1WindowAnimation["W1Anim"].time = w1WindowAnimation["W1Anim"].length;
            w1WindowAnimation.Play();
        }
        else if(ButtonName == "W2close")
        {
            w2WindowAnimation["W2Anim"].speed = -1;
            w2WindowAnimation["W2Anim"].time = w2WindowAnimation["W2Anim"].length;
            w2WindowAnimation.Play();
        }
        else if(ButtonName == "W3close")
        {
            w3WindowAnimation["W3Anim"].speed = -1;
            w3WindowAnimation["W3Anim"].time = w3WindowAnimation["W3Anim"].length;
            w3WindowAnimation.Play();
        }
    }
}
