using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIN : MonoBehaviour
{
    
    public Image blackFadeIn;
    
    // Start is called before the first frame update
    void Start()
    {
        blackFadeIn.canvasRenderer.SetAlpha(0.0f);

        fadeIn();
    }

    void fadeIn(){
        blackFadeIn.CrossFadeAlpha(1,2,false);
    }
}
