using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{
    Rigidbody rigidbody;
    public float power = 1f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    rigidbody = GetComponent<Rigidbody>();
                    rigidbody.AddForce(ray.direction * power, ForceMode.Impulse);
                }
            }
        }
    }
}