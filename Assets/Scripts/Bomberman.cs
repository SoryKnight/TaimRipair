using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomberman : MonoBehaviour
{
    public int Speed = 6;
    public Rigidbody rigidBody;

    public StageManager stage;
    public InteractiveObject state;
    public TimeFlowManager bullet;
    private Animator animator;
    public Vector3 direction;
    private float  timeUsed;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        state = GetComponent<InteractiveObject>();
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        if (!bullet.active || state.normalize){
            this.transform.Translate(direction * Speed * Time.deltaTime);
            if (animator != null){
                animator.speed = 1f;
            }
        }else if (bullet.active){
            if (animator != null){
                animator.speed = 0.5f;

            }
            this.transform.Translate(direction * Speed * Time.deltaTime * bullet.timeFactor);
            //rigidBody.velocity *= bullet.timeFactor;
            //rigidBody.angularVelocity *= bullet.timeFactor;

        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "InteractiveObject"){
            // this.transform.Translate(Vector3.up * Speed * 100 * Time.deltaTime);
            stage.setVerdictLose();
            rigidBody.AddForce(Vector3.up * 98f);
            rigidBody.AddForce(Vector3.left * 98f);
            Debug.Log("Collisioned with " + other.gameObject.name);
            if (animator != null){

                animator.SetBool("isDead", true);
            }
            if (other.gameObject.GetComponent<Animator>() != null){

                other.gameObject.GetComponent<Animator>().SetBool("isDead",true);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Trigger"){
            bullet.DoSlowMotion();
            timeUsed = Time.fixedDeltaTime;
            Destroy(other.gameObject);
        }

    }
}
