using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Robot : MonoBehaviour
{
    public float jumpForce { get; protected set; } // ENCAPSULATION
    protected GameObject robot;
    protected Rigidbody robotRb;
    public TextMeshProUGUI cloudText;
    public RawImage cloud;

    public virtual void Start()
    {
        robot = this.gameObject;
        robotRb = robot.GetComponent<Rigidbody>();
        cloud.gameObject.SetActive(false);
    }

    public virtual void Jump() // ABSTRACTION
    {
        robotRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public virtual void Delete() // ABSTRACTION
    {
        robot.SetActive(false);
    }
    
    private IEnumerator Delay() // ABSTRACTION
    {
       yield return new WaitForSeconds(1.0f);
       cloud.gameObject.SetActive(false);
    }

    public virtual void GreetingText()
    {
        cloudText.text = "Hi, I'm " + robot.name;
    }

    public virtual void GreetingCloud()
    {
        GreetingText();
        cloud.gameObject.SetActive(true);
        StartCoroutine(Delay());
        //cloud.gameObject.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

//Robot1 75mass - 300 JF
//Robot2 60mass - 270JF
//Robot3 90mass - 250JF