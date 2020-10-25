using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour
{
    public Animator animator;
    public bool isActive;
    public bool notActive;
    // Update is called once per frame
    void Update()

    {
        if(isActive==true){
            animator.SetBool("Show",true);
            animator.SetBool("Hide",false);
            if(Input.GetKeyDown(KeyCode.E)){
                gameObject.SetActive(false);
            }
        }
        if(notActive==true){
            animator.SetBool("Show",false);
            animator.SetBool("Hide",true);
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
