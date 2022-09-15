using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{

    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;

    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position -cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        yield return new WaitForFixedUpdate();
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }

}
