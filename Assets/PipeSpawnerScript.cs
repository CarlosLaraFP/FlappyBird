using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Prefabricated game object
    public GameObject pipe;

    // Both in Newtonian seconds
    public float spawnRate = 2.0f;
    private float timer = 0;

    // Y coordinate bounds
    public float minY = -10.0f;
    public float maxY = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer < spawnRate)
        {
            // // Tracks time by accumulating the seconds from the last frame to the current frame
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipes();

            timer = 0;
        }
    }

    private void spawnPipes()
    {
        // Instantiating prefabs at runtime
        Instantiate(pipe, getRandomYPosition(this.transform.position), this.transform.rotation);
        // we pass the position and rotation of the object holding the script (the Pipe Spawner)
    }

    private Vector3 getRandomYPosition(Vector3 position)
    {
        return new Vector3(position.x, position.y + Random.Range(minY, maxY), position.z);
    }
}
