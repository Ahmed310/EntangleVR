using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectToSpawn;
    [SerializeField]
    private Transform _output;

    public void OnHoverEnter() 
    {
        if (_objectToSpawn && _output)
        {
            GameObject spawnedObject = Instantiate(_objectToSpawn, _output.position, _output.rotation);
        }
        else Debug.Log("No object to spawn specified");
    }
}
