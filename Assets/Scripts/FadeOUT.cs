using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOUT : MonoBehaviour
{
    public Image blackFadeOut;
    
    // Start is called before the first frame update
    void Start()
    {
        blackFadeOut.canvasRenderer.SetAlpha(1.0f);

        fadeIn();
    }

    void fadeIn(){
        blackFadeOut.CrossFadeAlpha(0,2,false);
    }
}
