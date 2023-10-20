using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float levitationFactor;

    // Start is called before the first frame update
    void Start()
    {
        this.name = "Flappy";
        // TODO: Introduce difficulty by adjusting both of these at runtime
        rigidBody.gravityScale = 2;
        levitationFactor = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * levitationFactor;
        }
    }
}
