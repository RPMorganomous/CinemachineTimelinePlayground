using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{

    //[SerializeField]
    //private int _speed;
    [SerializeField]
    private int _rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        transform.Rotate(0, Time.deltaTime * _rotate, 0, Space.Self);
    }
}
