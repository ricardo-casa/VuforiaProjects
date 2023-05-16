using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private bool rotation = false;

    private void OnMouseDown(){
        rotation = !rotation;
    }

    void Update()
    {
        if(rotation)
        {
            transform.Rotate(new Vector3(0f, 25f, 0f) * Time.deltaTime);
        }        
    }
}