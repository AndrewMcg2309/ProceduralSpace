using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public float speed = 5.0f;
    private Transform target;

    Color color;

    void Start()
    {
        //transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0f, 0f, 0f);
        sphere.transform.localScale = new Vector3(20f, 20f, 20f);

       // Material mat = GetComponent<Material>();
        Material mat = new Material(Shader.Find("New Material"));

       // sphere.renderer.material = mat;

        
        //target = sphere.transform;
        //target.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);
        //target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);


    }

    void Update()
    {
        
    }
}
