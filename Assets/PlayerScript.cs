using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myPlayer;
    public float jumpStrength;
    public Text ScorePoint;
    public GameOver replay;

    private bool isGrounded;
    private float score;
    private bool isJumping = true;

    void Start()
    {
        if (replay == null)
        {
            replay = FindObjectOfType<GameOver>();
        }
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
            ScorePoint.text = "SCORE: " + ((int)score).ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            isJumping = false;
            Time.timeScale = 0f;
            if (replay != null)
            {
                replay.gameOver();
            }
        }
    }
}