using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Mouse3Pins : MonoBehaviour
{
    [SerializeField] protected int NumberOfThrow;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected GameObject Pin1;
    [SerializeField] protected GameObject Pin2;
    [SerializeField] protected GameObject Pin3;
    protected Vector3 velocityOfSpawnedObject;
    [SerializeField] protected string NextSceneName;
    [SerializeField] TextMeshPro text;
    private float EPS = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        //pos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        float z1 = Pin1.transform.rotation.z;
        float z2 = Pin2.transform.rotation.z;
        float z3 = Pin3.transform.rotation.z;
        //Debug.Log(z1);
        if ((z1 > EPS || z1 < -EPS) && (z2 > EPS || z2 < -EPS) && (z3 > EPS || z3 < -EPS))
        {
            SceneManager.LoadScene(NextSceneName); ;
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

}
