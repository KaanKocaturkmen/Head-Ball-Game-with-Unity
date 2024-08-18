using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public bool stop;
    public GameObject Panel;
    
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            stop = !stop;
        }
        if (stop)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        else { 
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
