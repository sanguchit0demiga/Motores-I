using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpforce;
    public Vector2 inputvector;
    public Rigidbody rigidBody;
    void Start()
    {
       rigidBody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        inputvector.x = Input.GetAxis("Horizontal");
        inputvector.y = Input.GetAxis("Vertical");

       rigidBody.AddForce(inputvector.x*speed,0f, inputvector.y*speed, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(0f, jumpforce,0f, ForceMode.Impulse);
        }
    }
}
