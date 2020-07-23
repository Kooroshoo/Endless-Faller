using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreatingPlatforms : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    public float instantiateRateInSeconds;
    public float platformSpeed;
    private float totalTime;
    public float difficultyRate = 0.1f;
    

    float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0;
        Instantiate(platforms[Random.Range(0, 5)], new Vector3(0, 2, -9), Quaternion.identity);
        //Load the Initial Spawn Rate.json file
        string json = File.ReadAllText(Application.dataPath + "/Initial Parameters.json");
        Initial_Parameters initial_Parameters = JsonUtility.FromJson<Initial_Parameters>(json);
        platformSpeed = initial_Parameters.platformSpeed;
        instantiateRateInSeconds = initial_Parameters.instantiateRateInSeconds;
        difficultyRate = initial_Parameters.difficultyRate;



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
            platformSpeed = platformSpeed + difficultyRate*2;
            instantiateRateInSeconds = instantiateRateInSeconds - difficultyRate;
            totalTime = 0;
        }



    }

    private class Initial_Parameters
    {
        public float platformSpeed;
        public float instantiateRateInSeconds;
        public float difficultyRate;
    }

}
