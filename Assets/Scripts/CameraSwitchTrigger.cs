using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    private CameraManager _camManager;

    [SerializeField]
    private int _whichCamera;

    // Start is called before the first frame update
    void Start()
    {
        _camManager = GameObject.Find("Managers").GetComponent<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager.ResetAllCams();
            _camManager.SetMasterCam(_whichCamera);
        }
        
    }

}
