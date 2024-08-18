using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public int firstGoal, secondGoal;
    public Text score1, score2;
    Rigidbody2D goalRigidbody;
    public bool goal;
    public Vector3 firstPlayer, secondPlayer, ball;
    void Start()
    {
        firstPlayer = GameObject.FindWithTag("Player1").transform.position;
        secondPlayer = GameObject.FindWithTag("Player2").transform.position;
        ball = transform.position;
        goal = false;
    }

    void Update()
    {
        score1.text = "" + firstGoal;
        score2.text = "" + secondGoal;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Gol1")
        {
            firstGoal++;
            goal = true;
            Invoke("Reset", 0);
        }
        if (collision.gameObject.name == "Gol2")
        {
            secondGoal++;
            goal = true;
            Invoke("Reset", 0);
        }
    }

    void Reset()
    {
        GameObject.FindWithTag("Player1").transform.position = firstPlayer;
        GameObject.FindWithTag("Player2").transform.position = secondPlayer;
        GameObject.Find("Ball").transform.position = ball;
        GameObject.Find("Ball").GetComponent<Rigidbody2D>().rotation = 0;

        //GameObject ball = GameObject.Find("Ball");

        // Set the ball's position to a fixed starting point (e.g., (0, 0))
        //ball.transform.position = new Vector3(0, 0, 0);

        // Get the Rigidbody2D component
        //Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();

        // Reset the velocity and angular velocity
        //rb.velocity = Vector2.zero;
        //rb.angularVelocity = 0;

        // Optionally, you can also reset the rotation
       // rb.rotation = 0;
        goal = false;
        CancelInvoke("Reset");
    }
}
