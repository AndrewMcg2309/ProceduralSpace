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

    void Start()
    {
        for(int i=0 ; i < numItemsToSpawn; i++)
        {
            SpreadItem();
        }

        
    }

    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
