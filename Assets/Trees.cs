using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trees : MonoBehaviour
{
    public float loopSpeed;
    public Renderer BGTree;

    void Update()
    {
        BGTree.material.mainTextureOffset += new Vector2(loopSpeed * Time.deltaTime, 0f);
    }
    
}
