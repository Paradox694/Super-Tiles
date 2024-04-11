using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Scale : MonoBehaviour
{
    int length = 1;
    int width = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(length, 1, width);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            length += 1;
            transform.localScale = new Vector3(length, 1, width);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            length -= 1;
            transform.localScale = new Vector3(length, 1, width);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            width += 1;
            transform.localScale = new Vector3(length, 1, width);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            width -= 1;
            transform.localScale = new Vector3(length, 1, width);
        }
    }
}
