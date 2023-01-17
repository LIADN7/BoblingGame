using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Mouse : MonoBehaviour
{
    [SerializeField] protected int NumberOfThrow;
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] protected GameObject[] Pins;

    protected Vector3 velocityOfSpawnedObject;
    [SerializeField] protected string NextSceneName;
    [SerializeField] protected TextMeshPro text;
    private static float EPS = 0.2f;
    [SerializeField] protected GameObject nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel.SetActive(false);
        
    }

    void FixedUpdate()
    {
        float[] z = new float[Pins.Length];
        for (int i = 0; i < z.Length; i++)
        {
            z[i] = Pins[i].transform.rotation.z;
        }
        

        //Debug.Log(z1);
        if (winFunc(z))
        {
            nextLevel.SetActive(true);
            //SceneManager.LoadScene(NextSceneName); ;
        }
            //0 is for when the left button is clicked, 1 is for the right
            
        text.transform.GetComponent<TextMeshPro>().text = "" + NumberOfThrow.ToString();
        velocityOfSpawnedObject = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        velocityOfSpawnedObject.z = 0;
        transform.position = velocityOfSpawnedObject;
        prefabToSpawn.transform.position = velocityOfSpawnedObject;
        //prefabToSpawn.transform.position.z = 0f;
        if (Input.GetMouseButtonUp(1))
        {
            if (NumberOfThrow > 0)
            {

                // Modify the text field of the new object.
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity).SetActive(true);
                NumberOfThrow--;
                
            }

        }
            
    }



    private static bool winFunc(float[] z)
    {
        for (int i = 0; i < z.Length; i++)
        {
            if (!(z[i] > EPS || z[i] < -EPS))
            {
                return false;
            }
        }


        return true;
    }
    
}
