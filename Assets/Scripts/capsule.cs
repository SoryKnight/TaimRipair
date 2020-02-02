using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{
    // Start is called before the first frame update
    public int Speed = 0;
    public Rigidbody rigidBody;
    public InteractiveObject state;
    public TimeFlowManager bullet;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        state = GetComponent<InteractiveObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!bullet.active || state.normalize){
            this.transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }else if (bullet.active){
            rigidBody.velocity *= bullet.timeFactor;
            rigidBody.angularVelocity *= bullet.timeFactor;

        }
    }
}
