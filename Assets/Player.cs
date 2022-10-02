using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float m_Speed = 5f;
    public GameObject camera;
    public Vector3 cameraOffset;
    private bool isGameOver = false;
    private bool isGameStarted = false;
    private int difficultyLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = transform.position + cameraOffset;

        if(!isGameStarted && isGameOver) return;
        
        if(transform.position.y < -10){
            gameObject.transform.parent.gameObject.BroadcastMessage("GameOver");
            isGameOver = true;
        }
    }

    void OnCollisionEnter(){
        if(difficultyLevel == 3){
            gameObject.transform.parent.gameObject.BroadcastMessage("GameOver");
            isGameOver = true;
        }
    }

    void FixedUpdate()
    {
        if(!isGameStarted) return;
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }

    public void GameStart(int level)
    {
        isGameStarted = true;
        difficultyLevel = level;
    }

}
