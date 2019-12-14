using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovPlayer2 : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;
    [SerializeField]
    private float forwardMoveSpeed = 1.5f;
    [SerializeField]
    private float backwardMoveSpeed = .05f;
    [SerializeField]
    private float turnSpeed = 100f;
    

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal2 = Input.GetAxis("Horizontal2");
        var vertical2 = Input.GetAxis("Vertical2");

        var movement = new Vector3(horizontal2, 0, vertical2);

        animator.SetFloat("Speed", vertical2);

        transform.Rotate(Vector3.up, horizontal2 * turnSpeed * Time.deltaTime);
         if (vertical2 != 0)
        {
            float moveSpeedToUse = (vertical2 > 0) ? forwardMoveSpeed : backwardMoveSpeed;

            characterController.SimpleMove(transform.forward * forwardMoveSpeed * vertical2);

        }


    }
}
