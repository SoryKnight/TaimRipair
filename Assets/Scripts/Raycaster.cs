using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "InteractiveObject")
                {
                    Debug.Log("Hit" + hit.collider.name);
                    
                    hit.collider.gameObject.GetComponent<InteractiveObject>().normalize = true;

                }
            }

        }
    }
}