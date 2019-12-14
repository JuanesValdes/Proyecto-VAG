using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 0.05f;

    private CinemachineComposer composer;

    // Start is called before the first frame update
    private void Start()
    {
        composer = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineComposer>();
    }

    // Update is called once per frame
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical3") * sensitivity;
        composer.m_TrackedObjectOffset.y += vertical;
        composer.m_TrackedObjectOffset.y = Mathf.Clamp(composer.m_TrackedObjectOffset.y, 0, 0.5f);

        //float horizontal = Input.GetAxis("Horizontal2") * sensitivity;
        //composer.m_TrackedObjectOffset.x += horizontal;
        //composer.m_TrackedObjectOffset.x = Mathf.Clamp(composer.m_TrackedObjectOffset.x, -0.2f, 0.2f);
    }
}
