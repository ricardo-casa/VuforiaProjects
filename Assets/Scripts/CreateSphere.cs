using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSphere : MonoBehaviour
{
    public GameObject prefab;
    public GameObject sphereSpawn;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Sphere") == null) //si no se encuentra la pelota
        {
            //instanciar a la posicion local del objeto vacio
            GameObject sphere = Instantiate(prefab, sphereSpawn.transform); 
            sphere.name = "Sphere";
            sphere.transform.localPosition = Vector3.zero;
            sphere.transform.localRotation = Quaternion.identity;
        }
    }
}
