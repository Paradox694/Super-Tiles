using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    public GameObject board;
    public GameObject[] cube;
    public float rotationSpeed;

    private void OnMouseDrag()
    {
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].transform.parent = board.transform;
        }

        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed;
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.down, rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].transform.parent = null;
        }

        if (Input.GetMouseButtonDown(2))
        {
            for (int i = 0; i < cube.Length; i++)
            {
                //cube[i].SetActive(false);
            }
        }
    }
}
