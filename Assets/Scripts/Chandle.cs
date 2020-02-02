using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chandle : MonoBehaviour
{
    public Rigidbody rigidBody;
    public InteractiveObject state;
    public TimeFlowManager bullet;
    private bool trigger = false;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        state = GetComponent<InteractiveObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (bullet.active && !state.normalize){
            rigidBody.useGravity = true;
            rigidBody.AddForce(Vector3.up * 9.8f*(1-(bullet.timeFactor*bullet.timeFactor)));
            trigger = true;
        }
    }
}
