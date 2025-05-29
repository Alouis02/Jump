using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    // Variables
    public Spawn obstaclesMovement;

    void Update()
    {
        transform.Translate(Vector2.left * obstaclesMovement.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            obstaclesMovement.SpawnObstacles();
        }
    }
}