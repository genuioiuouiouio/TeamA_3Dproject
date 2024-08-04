using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityFx.Outline;
public class UI_Action : MonoBehaviour
{

    Camera mainCamera;
    RaycastHit hit;
    GameObject targetObject;
    string _tag = "NPC_Charactor";
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start(){
        //mainCamera = Camera.main;
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        layerMask = 1 << LayerMask.NameToLayer("NPC_Charactor");
    }

    // Update is called once per frame
    void Update(){
        CastRay();
    }

    void CastRay(){
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
       
        if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity,layerMask)){
            targetObject = hit.collider.gameObject;
            Debug.Log(targetObject.name);
            if(targetObject.CompareTag(_tag))
                targetObject.GetComponent<OutlineBehaviour>().OutlineWidth = 4;
        }
        else{
            targetObject = null;
        }
  }
}
