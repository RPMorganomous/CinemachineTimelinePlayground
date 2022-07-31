using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private GameObject[] _cams;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // on key press R turn off all but one camera
        if (Input.GetKeyDown(KeyCode.R))
        {
            _cams[0].SetActive(false);
            _cams[1].SetActive(false);
            _cams[2].SetActive(false);
            _cams[3].SetActive(false);
        }
    }
}
