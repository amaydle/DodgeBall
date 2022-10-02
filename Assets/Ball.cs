using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigidBody;
    public float moveSpeed = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rigidBody = GetComponent<Rigidbody>();
        transform.position = new Vector3(transform.position.x,transform.position.y,Random.Range(-3.0f,3.0f));
    }

    void Update(){
        // Debug.Log(transform.position.x);

        if(transform.position.y < -10){
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 input = new Vector3(-0.5f, 0, 0);

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rigidBody.MovePosition(transform.position + input * Time.deltaTime * moveSpeed);
    }

}