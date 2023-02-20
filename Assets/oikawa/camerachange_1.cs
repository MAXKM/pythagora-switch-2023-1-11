using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange_1 : MonoBehaviour
{
    public GameObject Sancame;
    public GameObject Nicame;
    public Collider changeone;
   

    // Start is called before the first frame update
    void Start()
    {
        Sancame = GameObject.Find("camesan");
        Nicame = GameObject.Find("cameni");

    }
    private void OnCollisionEnter(Collision collision)
    {
        Sancame.SetActive(true);
        Nicame.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
