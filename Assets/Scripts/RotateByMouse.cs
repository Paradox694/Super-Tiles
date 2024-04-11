using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    public GameObject cube;
    public float rotationSpeed;

    private void OnMouseDrag()
    {
        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed;
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.down, rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            cube.SetActive(false);
        }
    }
}
