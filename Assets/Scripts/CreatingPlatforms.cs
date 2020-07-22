using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPlatforms : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private float instantiateRate;
    float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime>= instantiateRate)
        {
            Instantiate(platforms[Random.Range(0, 5)], new Vector3(0, 0, -8), Quaternion.identity);
            elapsedTime = 0;
        }
        
        
        
    }

}
