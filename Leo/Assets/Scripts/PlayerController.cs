using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float playerSpeed = 8.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          float x = Input.GetAxis("Horizontal");
          float z = Input.GetAxis("Vertical");

          Vector3 move = transform.right * x + transform.forward * z;

          characterController.Move(move * playerSpeed * Time.deltaTime);
    }
}
