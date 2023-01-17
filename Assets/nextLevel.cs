using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    [SerializeField] protected string NextLevel;


    void OnMouseDown()
    {
        SceneManager.LoadScene(NextLevel);

    }
}
