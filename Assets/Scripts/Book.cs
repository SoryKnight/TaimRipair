using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public Rigidbody rigidBody;
    public bool normalize = false;
    public InteractiveObject state;
    public TimeFlowManager bullet;
    private bool once=true;
    private float  timeUsed;

    private Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        state = GetComponent<InteractiveObject>();
        myVector = new Vector3 (-0.675f, -0.351f, -0.4f);
        rigidBody.AddForce(myVector*100f);
    }

    // Update is called once per framefloat accelx, accely, accelz = 0;

    void Update ()
    {
        if (!bullet.active || state.normalize){
            transform.Rotate (Vector3.up * 500 * Time.deltaTime, Space.Self);
            // this.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            if (!once){
                rigidBody.velocity /= bullet.timeFactor;
                rigidBody.angularVelocity /= bullet.timeFactor;
                once = !once;
            }
        }else if (bullet.active){
            
            transform.Rotate (Vector3.up * 500 * Time.deltaTime*bullet.timeFactor, Space.Self);
            if (once){
                rigidBody.velocity *= bullet.timeFactor;
                rigidBody.angularVelocity *= bullet.timeFactor;
                once = !once;

            }
            // rigidBody.AddForce(myVector*2f*bullet.timeFactor);
            
            //rigidBody.velocity *= bullet.timeFactor;
            //rigidBody.angularVelocity *= bullet.timeFactor;

        }
        
    }
}
