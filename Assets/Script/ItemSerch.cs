using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSerch : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Item")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                col.transform.GetComponent<Item>().GetItem();
                Destroy(col.gameObject);
                Debug.Log("アイテムを拾いました！");
            }
        }
    }
}