using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnC : MonoBehaviour
{
    private BrainChallenge _camMann;

    // Start is called before the first frame update
    void Start()
    {
        _camMann = GameObject.Find("CameraManager").GetComponent<BrainChallenge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            _camMann.SetLowCamsPriorities();
            _camMann.SetCurrentCam();
        }
    }
}
