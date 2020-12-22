using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAreaSpawner : MonoBehaviour
{
    public GameObject itemToSpread;

    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;



    void Start()
    {
        SpreadItem();
    }


    void SpreadItem()
    {
        Vector3 randPosition = new Vector3 (Random.Range(-itemXSpread, itemXSpread), 
                                            Random.Range(-itemYSpread, itemYSpread), 
                                            Random.Range(-itemZSpread, itemZSpread));

        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }

}
