using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCamera : MonoBehaviour
{
    public float dragSpeed = -0.06f;

    public void panControl() {
        if (Input.GetMouseButton(1)) {
            float x = Input.GetAxis("Mouse X") * dragSpeed;
            float y = Input.GetAxis("Mouse Y") * dragSpeed;

            x *= Camera.main.orthographicSize;
            y *= Camera.main.orthographicSize;

            transform.Translate(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        panControl();
    }
}
