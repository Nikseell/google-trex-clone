using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] obstacles;

    private void Start()
    {
        int randomIndex = Random.Range(0, obstacles.Length);
        obstacles[randomIndex].SetActive(true);
    }
}
