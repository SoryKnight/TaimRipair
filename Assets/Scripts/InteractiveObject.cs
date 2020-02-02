using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public Rigidbody rigidBody;
    public bool normalize = false;
    public TimeFlowManager bullet;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if (!bullet.active || normalize){         
        //     rigidBody.AddForce(Vector3.down * 9.8f);
        // }else if (bullet.active){
        //     rigidBody.AddForce(Vector3.down * 9.8f * (bullet.timeFactor*bullet.timeFactor));

        // }
    }
}
