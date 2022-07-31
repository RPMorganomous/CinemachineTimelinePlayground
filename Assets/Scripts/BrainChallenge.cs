using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BrainChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cams;
    public int _currentCamera;
    public bool _triggered = false;

    void Update()
    {
        if (_triggered == true) 
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (_currentCamera < (_cams.Length - 1))
                {
                    _currentCamera++;
                }
                else
                {
                    _currentCamera = 1;
                }
                SetLowCamsPriorities();
                SetCurrentCam();
            }
        }
    }
    public void SetLowCamsPriorities()
    {
        foreach (var c in _cams)
        {
            if (c.GetComponent<CinemachineVirtualCamera>())
            {
                c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }
            if (c.GetComponent<CinemachineBlendListCamera>())
            {
                c.GetComponent<CinemachineBlendListCamera>().Priority = 10;
            }
        }
    }
    public void SetCurrentCam()
    {
        if (_cams[_currentCamera].GetComponent<CinemachineVirtualCamera>())
        {
            _cams[_currentCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
        }
        
        if (_cams[_currentCamera].GetComponent<CinemachineBlendListCamera>())
        {
            _cams[_currentCamera].GetComponent<CinemachineBlendListCamera>().Priority = 15;
        }

    }
}
