using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public GameObject cube;

    public void TargetFound()
    {
        Color mat = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            1f
        );

        cube.GetComponent<Renderer>().material.color = mat;
    }
}