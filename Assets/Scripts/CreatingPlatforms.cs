using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPlatforms : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    public float instantiateRateInSeconds;
    public float platformSpeed;
    private float totalTime;
    public float DifficultyRate = 0.1f;
    

    float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0;
        Instantiate(platforms[Random.Range(0, 5)], new Vector3(0, 2, -9), Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime>= instantiateRateInSeconds)
        {
            Instantiate(platforms[Random.Range(0, 5)], new Vector3(0, 2, -9), Quaternion.identity);
            elapsedTime = 0;
        }

        totalTime += Time.deltaTime;
        if (totalTime > 10)
        {
            platformSpeed = platformSpeed + DifficultyRate*2;
            instantiateRateInSeconds = instantiateRateInSeconds - DifficultyRate;
            totalTime = 0;
        }



    }

}
