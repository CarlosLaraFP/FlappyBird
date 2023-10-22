using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float levitationFactor = 10.0f;
    public bool isAlive = true;
    public GameManagerScript gameManager;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.name = "Fringe";
        // TODO: Introduce difficulty by adjusting physics at runtime
        rigidBody.gravityScale = 2.5f;

        gameManager = GameObject
            .FindGameObjectWithTag(nameof(GameManagerScript))
            .GetComponent<GameManagerScript>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidBody.velocity = Vector2.up * levitationFactor;

            // Make the sprite glow
            spriteRenderer.color = Color.blue;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && isAlive)
        {
            // Remove the glow when the key is released
            spriteRenderer.color = Color.white;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        spriteRenderer.color = Color.red;
        isAlive = false;
    }
}
