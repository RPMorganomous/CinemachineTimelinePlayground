using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerCube : MonoBehaviour
{
    [SerializeField]
    private BrainChallenge _camMgr;

    //[SerializeField]
    //public int _theCamera = 1;

    // Start is called before the first frame update
    void Start()
    {
        // instead of SerializeField, could have done...
        //_camMgr = GameObject.Find("CameraManager").GetComponent<BrainChallenge>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(DelayTrigger());

            //_camMgr._triggered = true;
            //_camMgr.SetLowCamsPriorities();
            //_camMgr._currentCamera = 1;
            //_camMgr.SetCurrentCam();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(DelayExit());

        //_camMgr._triggered = false;
        //_camMgr.SetLowCamsPriorities();
        //_camMgr._currentCamera = 0;
        //_camMgr.SetCurrentCam();
    }

    private IEnumerator DelayTrigger()
    {
        yield return new WaitForSeconds(0.25f);

        _camMgr._triggered = true;
        _camMgr.SetLowCamsPriorities();
        _camMgr._currentCamera = 1;
        _camMgr.SetCurrentCam();
    }

    private IEnumerator DelayExit()
    {

        yield return new WaitForSeconds(0.25f);
        _camMgr._triggered = false;
        _camMgr.SetLowCamsPriorities();
        _camMgr._currentCamera = 0;
        _camMgr.SetCurrentCam();
    }
}
