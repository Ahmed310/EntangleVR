using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCube : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void OnActivate()
    {
        Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        _meshRenderer.material.color = randomColor;
    }        
}
