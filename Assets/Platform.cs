using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public float spawnRateEasy = 0.2f;
    public float spawnRateMedium = 0.05f;
    public float spawnRateHard = 0.2f;
    void Start()
    {
       
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, new Vector3(9.4f, 0.5f, 0f), Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke();
    }

    public void SetDifficulty(int level)
    {
        gameObject.transform.parent.gameObject.BroadcastMessage("GameStart", level);
    }

    public void GameStart(int level)
    {
        switch (level)
        {
            case 1:
                InvokeRepeating("SpawnBall", 2.0f, spawnRateEasy); 
                break;
            case 2:
                InvokeRepeating("SpawnBall", 2.0f, spawnRateMedium); 
                break;
            case 3:
                InvokeRepeating("SpawnBall", 2.0f, spawnRateHard); 
                break;
                
        }
    }
}
