using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Variables
    public GameObject obstacles;
    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;

    void Start()
    {
        CurrentSpeed = MinSpeed;
        SpawnObstacles();
    }

    public void SpawnObstacles()
    {
        GameObject newObstacle = Instantiate(obstacles, transform.position, transform.rotation);
        newObstacle.GetComponent<ObstaclesMovement>().obstacles = this; 
    }
}