using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float deadZoneX = -45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (this.transform.position.x <= deadZoneX)
        {
            Destroy(this.gameObject);
            //Debug.Log("Pipe deleted");
        }
    }
}
