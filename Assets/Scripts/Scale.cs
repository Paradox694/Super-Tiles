using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Scale : MonoBehaviour
{
    int length = 10;
    int width = 10;
    int height = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(length, height, width);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            length += 10;
            transform.localScale = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            length -= 10;
            transform.localScale = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            width += 10;
            transform.localScale = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            width -= 10;
            transform.localScale = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            height -= 10;
            transform.localScale = new Vector3(length, height, width);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            height += 10;
            transform.localScale = new Vector3(length, height, width);
        }
    }
}
