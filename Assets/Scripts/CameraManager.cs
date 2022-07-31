using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cameras;

    // Start is called before the first frame update
    void Start()
    {
        //ResetAllCams();
        //SetMasterCam();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAllCams()
    {
        foreach (var c in _cameras)
        {
            c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }
    }

    public void SetMasterCam(int whichCamera)
    {
        _cameras[whichCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
    }
}
