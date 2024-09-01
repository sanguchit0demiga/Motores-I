using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpforce;
    public Vector2 inputvector;
    public Rigidbody rigidBody;
    public Vector3 velocity;
    public float velocityMagnitude;
    public bool CanJump;

    void Start()
    {
       rigidBody = GetComponent<Rigidbody>(); 
        CanJump = true;
    }


    // Update is called once per frame
    void Update()
    {
        inputvector.x = Input.GetAxis("Horizontal");
        inputvector.y = Input.GetAxis("Vertical");

       rigidBody.AddForce(inputvector.x*speed,0f, inputvector.y*speed, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            rigidBody.AddForce(0f, jumpforce,0f, ForceMode.Impulse);
            CanJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("choque contra: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Ground"))
        {
            CanJump = true;
        }
        if (collision.gameObject.CompareTag("Killzone"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
