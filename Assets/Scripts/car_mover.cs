using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_mover : MonoBehaviour
{
    [SerializeField] public float speed ;

    void Start()
    {

    }

    void Update()
    {
        // Move the object to the right based on speed and deltaTime
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}



