using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        this.span = Random.Range(0.5f, 1.0f);
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;

            this.span = Random.Range(0.5f, 1.0f);

            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-8, 8);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}