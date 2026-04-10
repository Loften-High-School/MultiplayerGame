using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 leftForce = new Vector3(0.0f, -1.0f, 0.0f);

public Vector3 rightForce = new Vector3(0.0f, 1.0f, 0.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
{
GetComponent<Rigidbody2D>().AddForce(rightForce);
}
if (Input.GetKey(KeyCode.A))
{
GetComponent<Rigidbody2D>().AddForce(leftForce);
    }

    }
    
}
