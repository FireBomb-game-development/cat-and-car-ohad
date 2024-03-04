using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_spwan : MonoBehaviour
{
    [SerializeField] GameObject carPrefab;
    Vector3 positionOfSpawnedObject; //Stores the position where the cars will be spawned.
    Quaternion rotationOfSpawnedObject = Quaternion.identity;//Stores the rotation of spawned cars; initialized as no rotation.
    [SerializeField] public  float min_delay ;
    [SerializeField] public float max_delay ;
    [SerializeField] public float min_speed ; // Minimum speed for the car
    [SerializeField] public float max_speed ; // Maximum speed for the car

    void Start()
    {
        positionOfSpawnedObject = transform.position;//Sets the initial spawn position to the current position of the object.
        StartCoroutine(SpawnCar());
    }

    private IEnumerator SpawnCar()
    {
        while (true)
        {
            float delay = Random.Range(min_delay, max_delay);
            float speed = Random.Range(min_speed, max_speed);

            yield return new WaitForSeconds(delay);// Pauses the coroutine for the randomly generated delay before spawning the next car.


            GameObject spawnedCar = Instantiate(carPrefab, positionOfSpawnedObject, rotationOfSpawnedObject);

            // Access the car_mover script and set its speed
            car_mover moverScript = spawnedCar.GetComponent<car_mover>();
            if(speed < 0)
            {
                speed *= -1;
                spawnedCar.transform.Rotate(0f, 180f, 0f);
            }
            if (moverScript != null)
            {
                moverScript.SetSpeed(speed);
            }
        }
    }
}


