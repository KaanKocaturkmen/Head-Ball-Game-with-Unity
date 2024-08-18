using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public string player;
    void Start() { }

    void Update()
    {
        //For Player 1
        if (Input.GetKey(KeyCode.D) && player == "1") { 
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) && player == "1")
        {
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && player == "1")
        {
            GetComponent<Rigidbody2D>() .AddForce (Vector3.up * 300000);
        }
        //For Player 2
        if (Input.GetKeyDown(KeyCode.UpArrow) && player == "2")
        {
            GetComponent<Rigidbody2D>() .AddForce (Vector3.up * 300000);
        }
        if (Input.GetKey(KeyCode.RightArrow) && player == "2")
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && player == "2")
        {
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
        }
    }
}
