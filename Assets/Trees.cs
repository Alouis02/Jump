using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trees : MonoBehaviour
{
    [SerializeField] private RawImage _treeimg; // Reference to the RawImage component
    [SerializeField] private float _x, _y; // Speed of the scrolling effect

    void Update()
    {
        _treeimg.uvRect = new Rect(_treeimg.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _treeimg.uvRect.size);

    }
    
}
