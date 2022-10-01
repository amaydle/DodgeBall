using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public float spawnRate = 0.3f;

    void Start()
    {
       InvokeRepeating("SpawnBall", 2.0f, spawnRate); 
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, new Vector3(9.4f, 0.5f, 0f), Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke();
    }
}