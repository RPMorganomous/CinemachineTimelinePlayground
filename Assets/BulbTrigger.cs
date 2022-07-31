using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulb;

    // Start is called before the first frame update
    void Start()
    {
        //_bulb = GetComponent<GameObject>("BuildDirector002");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _bulb.SetActive(true);
        }
    }
}
