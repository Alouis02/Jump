using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // Variables
    public Rigidbody2D myPlayer;
    public float jumpStrength;
    private bool isGrounded;
    float score;
    bool isJumping = true;
    public Text ScorePoint;
    public Replay replay;
    

    void Start()
    {
        GameObject replayObject = GameObject.Find("GameManager"); // Replace with actual Replay GameObject name
        if (replayObject != null)
        {
            replay = replayObject.GetComponent<Replay>();
        }
    }

    private void Score()
    {
        score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myPlayer.linearVelocity = Vector2.up * jumpStrength;
            isGrounded = false;
        }

        if (isJumping)
        {
            score += Time.deltaTime * 4;
            ScorePoint.text = "SCORE: " + score.ToString("F");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Spike"))
        {
            isJumping = false;
            Time.timeScale = 0;

            if (replay != null)
            {
                replay.GameOver();
            }   
        }
    }
}