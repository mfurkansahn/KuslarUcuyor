using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField]
    GameObject pipePrefab;

    [SerializeField]
    float spawnRate = 10;

    float timer = 0;

    [SerializeField]
    float heightOffsetPipe = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }    
    }

    void spawnPipe()
    {
        float lowestPointPipe = transform.position.y - heightOffsetPipe;
        float highestPointPipe = transform.position.y + heightOffsetPipe;
        Instantiate(pipePrefab,new Vector3(transform.position.x, Random.Range(lowestPointPipe, highestPointPipe), 0), transform.rotation);
    }
}
