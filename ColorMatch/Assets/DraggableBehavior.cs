using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{

    private Camera cameraObj;
    public bool draggable;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }

}
