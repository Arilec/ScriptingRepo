
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
        cameraOBJ = Camera.main; //assigns main camera
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraOBJ.ScreenToWorldPoint(Input.mousePosition); //mouse position offset
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate(); //wait for fixed update
        
        while (draggable)
        {   
            yield return new WaitForFixedUpdate(); //again
            position = cameraOBJ.ScreenToWorldPoint(Input.mousePosition) + offset; //combine mousepos with offset
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}