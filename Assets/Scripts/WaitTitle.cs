using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTitle : MonoBehaviour
{
    public float timer = 13.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        while(timer > 0){
            timer --;
        }

        if(timer <= 0.0f)
        {
            timer = 0.0f;
        }
        
        Debug.Log(timer);
    }
}
