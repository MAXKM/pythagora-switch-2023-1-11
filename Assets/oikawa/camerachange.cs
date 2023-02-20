using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour
{
    public GameObject Iticame;
    public GameObject Nicame;
    public Collider changeone;
   

    // Start is called before the first frame update
    void Start()
    {
        Iticame = GameObject.Find("cameiti");
        Nicame = GameObject.Find("cameni");

    }
    private void OnTriggerEnter(Collider other)
    {
        Iticame.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
