using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public GameObject fatherCube;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            (Instantiate(cube, new Vector3(-1, 0, 0), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            (Instantiate(cube, new Vector3(-1, 0, 1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            (Instantiate(cube, new Vector3(0, 0, 1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            (Instantiate(cube, new Vector3(1, 0, 1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            (Instantiate(cube, new Vector3(1, 0, 0), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            (Instantiate(cube, new Vector3(1, 0, -1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            (Instantiate(cube, new Vector3(0, 0, -1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            (Instantiate(cube, new Vector3(-1, 0, -1), Quaternion.identity) as GameObject).transform.parent = fatherCube.transform;
        }
    }
}
