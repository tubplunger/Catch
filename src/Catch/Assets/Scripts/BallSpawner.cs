using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    public float spawnHeight = 10f;
    public float spawnWidth = 8f;
    public float spawnInterval = 1f;

    public float fixedZPosition = 0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBall), 1f, spawnInterval);
    }

    void SpawnBall()
    {
        float randomX = Random.Range(-spawnWidth, spawnWidth);

        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, fixedZPosition);

        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }
}
