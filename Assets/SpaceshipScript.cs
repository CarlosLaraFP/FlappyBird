using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float levitationFactor = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.name = "Fringe";
        // TODO: Introduce difficulty by adjusting physics at runtime
        rigidBody.gravityScale = 2.5f;
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
