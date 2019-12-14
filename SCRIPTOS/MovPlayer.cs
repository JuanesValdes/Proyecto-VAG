using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*nombre: MovPlayer
autor: Juan Carlos ValdÉs Aguilar
 */

public class MovPlayer : MonoBehaviour
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

    // definimos su movimiento en base al axis horizontal y vertical para que así reconozca los diferentes inputs existentes
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);

        animator.SetFloat("Speed", vertical);

        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
         if (vertical != 0)
        {
            float moveSpeedToUse = (vertical > 0) ? forwardMoveSpeed : backwardMoveSpeed;

            characterController.SimpleMove(transform.forward * forwardMoveSpeed * vertical);

        }


    }
}
