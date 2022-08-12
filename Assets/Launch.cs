using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject gameObject;
    public float force; 
    // public Vector2 speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
                var ball = Instantiate(gameObject, new Vector3(0, 8.04f, -12.22f), Quaternion.identity);
                ball.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
                
            }
            
    }

    
}
