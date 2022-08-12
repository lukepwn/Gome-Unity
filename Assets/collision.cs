using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject gome;
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {
        Destroy(collision.gameObject);
        Destroy(ball.gameObject);
        // collision.gameObject.GetComponent
        for (var i=0; i<10; i++) 
        {
            var gome1 = Instantiate(gome, collision.transform.position, Quaternion.identity);
        }
       
    }
    
}
