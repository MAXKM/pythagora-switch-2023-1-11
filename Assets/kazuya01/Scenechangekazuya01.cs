using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangekazuya01 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube (5)")
        {
            SceneManager.LoadScene("Ayaka01");
        }

    }
}