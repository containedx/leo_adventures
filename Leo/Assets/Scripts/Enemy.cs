using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float wanderRadius = 10f;

    private CharacterController characterController;
    public Vector3 target;
    private Vector3 initialPosition;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        initialPosition = transform.position;
        FindRandomTarget();
    }

    private void Update()
    {
        WanderAround();
    }

    private void WanderAround()
    {
        var targetDirection = target - transform.position;
        Debug.Log(targetDirection.magnitude);
        if (targetDirection.magnitude > 0.1f)
        {
            characterController.Move(targetDirection.normalized * moveSpeed * Time.deltaTime);
        }
        else
        {
            FindRandomTarget();
        }
    }

    private void FindRandomTarget()
    {
        var randomPoint = Random.insideUnitCircle * wanderRadius;
        target = new Vector3(randomPoint.x, 0f, randomPoint.y) + initialPosition;
    }
}
