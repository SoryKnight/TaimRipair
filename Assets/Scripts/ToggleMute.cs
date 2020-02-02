using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMute : MonoBehaviour
{

    public GameObject pomo;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = pomo.transform.position;
    }
}
