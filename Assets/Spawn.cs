using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Variables
    public GameObject Object;
    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    public float SpeedIncrease;

    void Start()
    {
        CurrentSpeed = MinSpeed;
        SpawnObstacles();
    }

    public void RandomObstacle()
    {
        float randomized = Random.Range(0.1f, 1.2f);
        Invoke("SpawnObstacles", randomized);

    }

    void SpawnObstacles()
    {
        GameObject newObstacle = Instantiate(Object, transform.position, transform.rotation);
        newObstacle.GetComponent<ObstaclesMovement>().obstacles = this; 
    }

    void Update() 
    {
        if (CurrentSpeed < MaxSpeed) 
        {
            CurrentSpeed += SpeedIncrease;
        }
    }
}