using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increase_ball : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("seikou");
        Instantiate(Ball, new Vector3(1.1f, 10.5f, 23.1f),Quaternion.identity);
        Instantiate(Ball, new Vector3(-0.9f, 10.5f, 23.1f), Quaternion.identity);
        
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
