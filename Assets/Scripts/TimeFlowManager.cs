using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFlowManager : MonoBehaviour
{
    public float slowdownFactor;
    public float slowdownLength;

    private float timerFixTimeout = 0;
    public float timeFactor = 1;
    private bool triggered = false;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void DoSlowMotion() {
        
        if (triggered) return;
        Debug.Log("DoSlowMotion");
        active = true;
        // Time.timeScale = slowdownFactor;
        // Time.fixedDeltaTime = 0.02f * Time.timeScale;
        timerFixTimeout = slowdownLength;
        timeFactor = slowdownFactor;
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate() {
        timerFixTimeout -= Time.unscaledDeltaTime;
        if (timerFixTimeout <= 0){
            active = false;
        }
    }
}
