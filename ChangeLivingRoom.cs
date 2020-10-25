using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLivingRoom : MonoBehaviour
{
    public bool isActive;
    public bool notActive;

    // Update is called once per frame
    void Update()
    {   if(Input.GetKeyDown(KeyCode.E)){
        if(isActive==true){
        GameObject root=GameObject.Find("Kitchen");
        GameObject target=root.transform.Find("DPC").gameObject;
        target.SetActive(true);
        GameObject.Find("DinnerPlate").SetActive(false);
        GameObject.Find("LivingRoom").SetActive(false);
        GameObject target2=root.transform.Find("LivingRoom2").gameObject;
        target2.SetActive(true);
        
    }
    }
    }
    void OnTriggerEnter(Collider col){
    if(col.tag=="Player"){
            isActive=true;
            notActive=false;
        
    }
}
   void OnTriggerExit(Collider col){
    if(col.tag=="Player"){
        notActive=true;
        isActive=false;

    }
   }

}
