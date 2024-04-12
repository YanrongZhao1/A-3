using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player") 
        { 
            Destroy(gameObject);
            
        }
    }
}
