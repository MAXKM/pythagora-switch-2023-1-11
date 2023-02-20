using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_scripts : MonoBehaviour
{
    public Rigidbody ball;
    public float sin ;
    public float Ti;
    

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        sin = Mathf.Sin(Time.time);
        Ti = Time.time;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "han")
        {
            ball.AddForce(0.0f, 0.0f, -5.0f, ForceMode.VelocityChange);
        }
        if (collision.gameObject.tag == "han_RL")
        {
            ball.AddForce(0.0f, -1.0f, -10.0f, ForceMode.VelocityChange);
        }
        if (collision.gameObject.tag == "spring")
        {
            ball.AddForce(0.0f, 13.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (collision.gameObject.name == "spring_R")
        {
            ball.AddForce(-10.0f, 10.0f, 4.5f, ForceMode.VelocityChange);
        }
        if (collision.gameObject.name == "spring_L")
        {
            ball.AddForce(10.0f, 10.0f, 5.0f, ForceMode.VelocityChange);
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "utuwa")
        {
            if((int)Time.time % 2 == 0)
            {
                ball.AddForce(-sin * 30.0f, -3.0f, sin * 30.0f, ForceMode.Force);
            }
            else
            {
                ball.AddForce(sin * 30.0f, 4.0f, -sin * 30.0f, ForceMode.Force);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * 15.0f);
        Ti = (int)Time.time;
    }
}
