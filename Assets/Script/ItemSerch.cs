using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSerch : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Item")
        {
            //col.GetComponent<Item>().Interact();
            Debug.Log("Interact Item");
        }
    }
}