using UnityEngine;
using Random = System.Random;

public class BallsCreator : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float timeToNewSpawn;
    private float ySpawnPoint = 5.4f;
    private int maxX = 2;
    private int minX = -2;
    private float timer;

    private void Update()
    {
        Random random = new Random();
        timer += Time.deltaTime;

        if (timer >= timeToNewSpawn)
        {
            timer = 0;
            Instantiate(ballPrefab, new Vector3(random.Next(minX, maxX) * (float) random.NextDouble(), ySpawnPoint, 0),
                Quaternion.identity);
        }
    }
}