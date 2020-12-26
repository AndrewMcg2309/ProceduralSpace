using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAreaSpawner : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpawn = 20;

    public float itemXSpread = 20;
    public float itemYSpread = 20;
    public float itemZSpread = 20;


    public float scale = 10;

    List<GameObject> elements = new List<GameObject>();
    List<Vector3> startPositions = new List<Vector3>();

    void Start()
    {
        SpreadItem();    
    }

    void SpreadItem()
    {
        for(int i=0 ; i < numItemsToSpawn; i++)
        {
            Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
            GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);

            startPositions.Add(randPosition);
            clone.transform.parent = this.transform;
            clone.GetComponent<Renderer>().material.color = Color.HSVToRGB(
            i / (float)AudioAnalyzer.bands.Length
            , 1
            , 1
            );
            elements.Add(clone);
        }
    }




    void Update()
    {
        
        for (int i = 0; i < elements.Count; i++) 
        {
            Vector3 ls = elements[i].transform.localScale;
            ls.y = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[i] * scale), Time.deltaTime * 3.0f);
            elements[i].transform.localScale = ls;
            Vector3 pos = elements[i].transform.position;
            pos.y = startPositions[i].y + (ls.y / 2);
            elements[i].transform.position = pos;
        }
    }
}
