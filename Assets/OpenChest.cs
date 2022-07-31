using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private GameObject _item;
    [SerializeField] private GameObject _spawnLocation;

    private bool alreadyOpen = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (alreadyOpen == false)
        {
            if(other.CompareTag("Player"))
            {
                _director.Play();
                Invoke("InstantiateSword", 4f);
                alreadyOpen = true;
            }
        }
    }

    private void InstantiateSword()
    {
        Instantiate(_item, _spawnLocation.transform.position, Quaternion.identity);
    }
}
