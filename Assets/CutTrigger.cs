using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutTrigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _directorNew;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherNew)
    {
        //throw new NotImplementedException();
        if (otherNew.CompareTag("Player"))
        {
            _directorNew.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }
}
