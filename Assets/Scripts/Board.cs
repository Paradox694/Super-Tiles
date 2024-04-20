using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int size;

    public GameObject pooledObj;

    public int pooledAmount;

    List<GameObject> pooledObjects;

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObj);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (size == 0)
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                pooledObjects[i].SetActive(false);
            }
        }

        if (size == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                pooledObjects[i].SetActive(true);
            }

            pooledObjects[1].transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (size == 2)
        {
            for (int i = 1; i < 5; i++)
            {
                pooledObjects[i].SetActive(true);
            }

            pooledObjects[1].transform.position = new Vector3(-0.5f, 0.0f, -0.5f);
            pooledObjects[2].transform.position = new Vector3(0.5f, 0.0f, -0.5f);
            pooledObjects[3].transform.position = new Vector3(0.5f, 0.0f, 0.5f);
            pooledObjects[4].transform.position = new Vector3(-0.5f, 0.0f, 0.5f);
        }

        if (size == 3)
        {
            for (int i = 5; i < 14; i++)
            {
                pooledObjects[i].SetActive(true);
            }

            pooledObjects[5].transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            pooledObjects[6].transform.position = new Vector3(-1.0f, 0.0f, -1.0f);
            pooledObjects[7].transform.position = new Vector3(-1.0f, 0.0f, 0.0f);
            pooledObjects[8].transform.position = new Vector3(-1.0f, 0.0f, 1.0f);
            pooledObjects[9].transform.position = new Vector3(0.0f, 0.0f, 1.0f);
            pooledObjects[10].transform.position = new Vector3(1.0f, 0.0f, 1.0f);
            pooledObjects[11].transform.position = new Vector3(1.0f, 0.0f, 0.0f);
            pooledObjects[12].transform.position = new Vector3(1.0f, 0.0f, -1.0f);
            pooledObjects[13].transform.position = new Vector3(0.0f, 0.0f, -1.0f);

        }
    }
}
