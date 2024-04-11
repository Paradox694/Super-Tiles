using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;

    private int index = 1;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (materials.Length == 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(1))
        {
            index += 1;
            if (index == materials.Length + 1)
            {
                index = 1;
            }

            print(index);

            rend.sharedMaterial = materials[index-1];
        }
    }
}
