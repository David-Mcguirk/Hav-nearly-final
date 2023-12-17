using UnityEngine;
using UnityEngine.SceneManagement;

public class balleasyController : MonoBehaviour
{
    // Reference to the player GameObject
    public GameObject player;

    // Initial position of the ball
    private Vector3 initialPosition;

    // Scene to load on game over
    private string gameOverScene = "GameOverEasy";

    // Score variable
    private int score = 0;

    void Start()
    {
        // Save the initial position of the ball
        initialPosition = transform.position;
    }

    void Update()
    {
        // Check if the ball is touching the ground
        if (transform.position.y < 0)
        {
            // Trigger game over and show UI
            Destroy(gameObject);
            SceneManager.LoadScene(gameOverScene);
        }
    }

    // OnCollisionEnter is called when the ball collides with another collider
    void OnCollisionEnter(Collision collision)
    {
        // Check if the ball has collided with the player
        if (collision.gameObject.tag == "Player")
        {
            // Increase the score
            ScoreManager.scoreCounter += 1;

            // Reset the position of the ball to its initial position
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            // Additional collision logic if needed
        }
    }
}