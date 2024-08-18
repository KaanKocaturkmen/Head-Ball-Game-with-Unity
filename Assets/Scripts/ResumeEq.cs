using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeEq : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnterButton()
    {
        Application.LoadLevel("Scene2");
    }

    public void ExitButton()
    {
        Application.LoadLevel("Scene1(MENU)");
    }
}
