using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camerafollowsplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    public Vector3 CameraOffset;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + CameraOffset;
        transform.LookAt(playerTransform);
    }
}
