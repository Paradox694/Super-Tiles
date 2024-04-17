using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Scale : MonoBehaviour
{
    int length = 0;
    int width = 0;
    int height = 80;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(length, height, width);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            length -= 200;
            transform.position = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            length += 200;
            transform.position = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            width += 200;
            transform.position = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            width -= 200;
            transform.position = new Vector3(length, height, width);
        }

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    height -= 10;
        //    transform.localScale = new Vector3(length, height, width);
        //}

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    height += 10;
        //    transform.localScale = new Vector3(length, height, width);
        //}
    }
}
