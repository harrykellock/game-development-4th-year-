using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }
}
