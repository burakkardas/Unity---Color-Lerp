using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color[] _colors;
    [SerializeField] private int _index;
    [SerializeField] private float _changer;
    [SerializeField] private float _lerpTime;
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();   
    }
    void Update()
    {
        _meshRenderer.material.color = Color.Lerp(_meshRenderer.material.color, _colors[_index], _lerpTime * Time.deltaTime);

        _changer = Mathf.Lerp(_changer, 1, _lerpTime * Time.deltaTime);

        if(_changer > 0.9f) {
            _changer = 0;
            _index++;

            if(_index >= _colors.Length) {
                _index = 0;
            }
        } 
    }
}
