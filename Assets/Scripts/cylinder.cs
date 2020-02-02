﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    public int Speed = 10;
    public bool normalize = false;
    public TimeFlowManager bullet;
    private float  timeUsed;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if (!bullet.active || normalize){
            timeUsed = Time.deltaTime;
        }else if (bullet.active){
            timeUsed = Time.deltaTime*bullet.timeFactor;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * Speed * timeUsed);
        // if (!NoSlowed){
        //     this.transform.Translate(Vector3.right * Speed * Time.fixedDeltaTime);
        // }else{
        //     this.transform.Translate(Vector3.right * Speed * Time.unscaledDeltaTime);
        // }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Trigger"){
            bullet.DoSlowMotion();
            timeUsed = Time.fixedDeltaTime;
        }

    }

    private void OnCollisionEnter(Collision other) {
        
        animator.SetBool("isDead", true);
    }
    
}
