using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_y : MonoBehaviour
{
    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "han_RL")
        {
            ball.AddForce(0.0f, 0.0f, -10.0f, ForceMode.VelocityChange);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
