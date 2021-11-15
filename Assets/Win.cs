using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] int time;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator passiveMe()
    {
        yield return new WaitForSeconds(time);
        Debug.Log("aaaaa");
    }
    // Update is called once per frame
    void Update()
    {
        passiveMe();
        //yield return new WaitForSeconds(time);
    }
}
