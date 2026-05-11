using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    // Variables
    public Spawn obstacles;

    void Update()
    {
        transform.Translate(Vector2.left * obstacles.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            obstacles.RandomObstacle();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}