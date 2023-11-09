
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    public bool draggable;
    private Camera cameraOBJ;
    public UnityEvent startDragEvent, endDragEvent;

    public Vector3 position, offset;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOBJ = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraOBJ.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();
        
        while (draggable)
        {   
            yield return new WaitForFixedUpdate();
            position = cameraOBJ.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}