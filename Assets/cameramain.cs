using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramain : MonoBehaviour
{
    public Vector3 offset;
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball==null)
        {
            ball = GameObject.Find("Sphere(Clone)");
        }
        else 
        {
            transform.position = ball.transform.position + offset;
        }
        
    }
}
