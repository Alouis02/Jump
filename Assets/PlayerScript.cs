using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Variables
    public Rigidbody2D myPlayer;
    public float jumpStrength;
    
    // 
    void Start()
    {
        
    }

    // 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            myPlayer.linearVelocity = Vector2.up * jumpStrength;
        }
    }
}
