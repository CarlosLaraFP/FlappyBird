using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Prefabricated game object
    public GameObject pipe;
    public float spawnRate = 2.0f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            // // Tracks time by accumulating the seconds from the last frame to the current frame
            timer += Time.deltaTime;
        }
        else
        {
            // Instantiating prefabs at runtime
            Instantiate(pipe, this.transform.position, this.transform.rotation);
            // we pass the position and rotation of the object holding the script (the Pipe Spawner)

            timer = 0;
        }
    }
}
