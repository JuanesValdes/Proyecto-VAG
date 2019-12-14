using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
    //Generamos una cámara que seguirá al jugador en todo momento y será posible su rotación dentro del eje del personaje con el uso del mouse
    public Transform PlayerTransform;

    public Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = true;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;

    public float RotationYSpeed = 0.5f;

    // Iniciamos la camara
    void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;	
	}
	
	// Lo llama despues una vez iniciada y al mover el mouse va a girar alrededor del player
	void LateUpdate () {

        if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);

            _cameraOffset = camTurnAngle * _cameraOffset;
        }

        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationYSpeed, Vector3.left);

            _cameraOffset = camTurnAngle * _cameraOffset;
        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
	}
}
