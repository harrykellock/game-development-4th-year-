using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{

    GameObject player;
    public GameObject restartcanvas;

    void Start()
    {
        player = GameObject.FindWithTag("Player");   
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");

        if (collision.gameObject == player)
        {
            Time.timeScale = 0;
            restartcanvas.SetActive(true);
        }
    }
}
