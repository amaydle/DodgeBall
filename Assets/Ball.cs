using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
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
        Vector3 m_Input = new Vector3(-0.5f, 0, 0);

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
}