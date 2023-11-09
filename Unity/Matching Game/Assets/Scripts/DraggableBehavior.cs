using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    public bool dragable;
    private Camera cameraOBJ;
    // Start is called before the first frame update
    void Start()
    {
        cameraOBJ = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        dragable = true;
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("drag");
        }
    }

    private void OnMouseUp()
    {
        dragable = false;
    }
}