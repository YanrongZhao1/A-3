using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roleMove : MonoBehaviour
{
    public Transform sphere;
    public Text scoreText;
    public float moveSpeed = 5;
    public int count;
    public AudioClip sound;
    private void Update()
    {
        Move();
  
    }
    private void Move()
    {
        if(Input.GetKey(KeyCode.D))
        {
            sphere.Translate(Vector3.left * moveSpeed * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            sphere.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            sphere.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            sphere.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "foodtag")
        {
            count++;
            scoreText.text = count.ToString();
        }
    }

}
