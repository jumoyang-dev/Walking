using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    public bool isActive;
    public bool notActive;
    // Update is called once per frame
    void Update()

    { if(Input.GetKeyDown(KeyCode.E)){
          if(isActive==true){
            animator.SetBool("Open",true);
            animator.SetBool("Close",false);
            
          }
        
    }
    if(notActive==true){
            animator.SetBool("Close",true);
            animator.SetBool("Open",false);
        }}



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
