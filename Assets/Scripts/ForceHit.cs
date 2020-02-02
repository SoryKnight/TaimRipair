using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceHit : MonoBehaviour
{
    private Bomberman player;
    public int correctorFactor =1;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Bomberman>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "InteractiveObject"){

            other.gameObject.GetComponent<Rigidbody>().AddForce(1000f*player.direction*correctorFactor);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
