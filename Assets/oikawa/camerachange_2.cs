using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange_2 : MonoBehaviour
{
    public GameObject Sancame;
    public GameObject yoncame;
    public Collider changeone;
    

    // Start is called before the first frame update
    void Start()
    {
        Sancame = GameObject.Find("camesan");
        yoncame = GameObject.Find("cameyon");
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        yoncame.SetActive(true);
        Destroy(Sancame);
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
