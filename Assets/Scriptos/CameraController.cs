using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

/*nombre: Camera controller
autor: Juan Carlos ValdÉs Aguilar
 */
public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 0.05f;

    private CinemachineComposer composer;

    // mandamos llamar al componente cinemachine
    private void Start()
    {
        composer = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineComposer>();
    }

    // le indicamos que siga el axis del mouse en su eje Y - X para poder realizar el movimiento de la camara de cinemachine
    private void Update()
    {
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        composer.m_TrackedObjectOffset.y += vertical;
        composer.m_TrackedObjectOffset.y = Mathf.Clamp(composer.m_TrackedObjectOffset.y, 0, 0.5f);

        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        composer.m_TrackedObjectOffset.x += horizontal;
        composer.m_TrackedObjectOffset.x = Mathf.Clamp(composer.m_TrackedObjectOffset.x, -0.2f, 0.2f);
    }
}
