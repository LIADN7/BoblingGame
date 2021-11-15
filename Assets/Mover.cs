using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;
    [SerializeField] int rotate;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, rotate) * Time.deltaTime);
        
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
