using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float speed;
    CreatingPlatforms creatingPlatforms;
    

    void Start()
    {
        creatingPlatforms = FindObjectOfType<CreatingPlatforms>();
        speed = creatingPlatforms.platformSpeed;
    }

    // Update is called once per frame
    void Update()
    {
            
        transform.position += Vector3.up * speed * Time.deltaTime;
        if (this.transform.position.y>20)
        {
            Object.Destroy(this.gameObject);
        }
    }
}