
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour
{

    [SerializeField] protected KeyCode RestartKey;
    [SerializeField] protected string sceneName;
    //[SerializeField] protected Vector3 velocityOfSpawnedObject;

    private void Update()
    {
        if (Input.GetKeyDown(RestartKey))
        {
            SceneManager.LoadScene(sceneName);
        }

    }

}
