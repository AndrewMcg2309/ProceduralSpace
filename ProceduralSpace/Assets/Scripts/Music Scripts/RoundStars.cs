using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundStars : MonoBehaviour {
    public float scale = 10;
    List<GameObject> elements = new List<GameObject>();


    //GameObject go = GameObject.Find("Planet");
    // ShapeSettings shapeSettings = GameObject.GetComponent <ShapeSettings> ();

	// Use this for initialization and for starting the code off 
	void Start () 
    {
        CreateVisualisers();
    }

    public float radius = 50;
    public float distance;

    void CreateVisualisers()
    {
        distance = 20f;
        //float theta = (Mathf.PI * 2.0f) / (float) AudioAnalyzer.frameSize;
        for (int i = 0 ; i < AudioAnalyzer.frameSize ; i ++)
        {
            Vector3 pos = new Vector3(distance, distance, distance
                //Mathf.Sin(theta * i) * radius
                //, 0
                //, Mathf.Cos(theta * i) * radius
                
            );
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = transform.TransformPoint(pos);
            cube.transform.parent = this.transform;
            cube.GetComponent<Renderer>().material.color = 
                Color.HSVToRGB(i / (float) AudioAnalyzer.frameSize, 1, 1);
            elements.Add(cube);

            distance += 5;
        }
    }

    // Update is called once per frame
    void Update () {
        for(int i = 0 ; i < elements.Count ; i ++)
        {
            Vector3 lscale = elements[i].transform.localScale; 
            lscale.y = Mathf.Lerp(lscale.y, 1 + (Mathf.Abs(AudioAnalyzer.spectrum[i]) * scale), Time.deltaTime * 10);
            elements[i].transform.localScale = lscale;        
        }
	}
}
