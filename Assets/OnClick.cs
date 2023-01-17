using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    [SerializeField] protected string sceneName;


    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
        // Destroy the gameObject after clicking on it
        //Destroy(gameObject);

    }
}
