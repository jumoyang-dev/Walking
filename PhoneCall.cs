using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    public bool isActive;
    public bool notActive;
   
    // Update is called once per frame

   
        
    
    void Update()
    {
        if(isActive==true){
            if(Input.GetKeyDown(KeyCode.E)){
                gameObject.GetComponent<AudioSource>().Pause();
                GameObject.Find("Phone").GetComponent<AudioSource>().Play();
            }
        }
    
    if(GameObject.Find("Phone").GetComponent<AudioSource>().isPlaying){

        GameObject.Find("TelecallText").GetComponent<TextFX>().enabled=true;
        GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled=false;
    }
    else{ 
       
        GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled=true;
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


