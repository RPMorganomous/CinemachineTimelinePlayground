using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomCamControl : MonoBehaviour
{
    [SerializeField] private GameObject _cam;
    [SerializeField] private GameObject _target1, _target2;
    private bool _firstTarget = true;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget();
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            _cam.GetComponent<CinemachineVirtualCamera>().LookAt = _target2.transform;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _cam.GetComponent<CinemachineVirtualCamera>().LookAt = _target1.transform;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fovUpdate();
        }
    }

    private void SwitchTarget()
    {
        if (_firstTarget == false)
        {
            _cam.GetComponent<CinemachineVirtualCamera>().LookAt = _target1.transform;
            _firstTarget = true;
        }
        else
        {
            _cam.GetComponent<CinemachineVirtualCamera>().LookAt = _target2.transform;
            _firstTarget = false;
        }
    }

    private void fovUpdate()
    {
        float FOV = _cam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;
        if (FOV < 10)
        {
            _cam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
        }
    }
}
