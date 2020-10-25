using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadLetter : MonoBehaviour
{   public Animator animator;
    public bool isActive;
    public bool notActive;
    private int i=0;
    
    void Update()
    {
      if(isActive==true){
          if(Input.GetKeyDown(KeyCode.E)){
              animator.SetBool("Show",true);
              GameObject root = GameObject.Find("Hallwaydoor");
              GameObject SignalTarget=root.transform.Find("HallSig").gameObject;
              SignalTarget.SetActive(true);
              root.transform.Find("HallwayDoor").gameObject.GetComponent<Door>().enabled=true;
              gameObject.GetComponent<AudioSource>().Play();
              GameObject.Find("TelecallText").GetComponent<TextFX>().enabled=false;
              i=i+1;
              

          }
      }
      
      if(gameObject.GetComponent<AudioSource>().isPlaying){
          GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled=false;}
      else{
            GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled=true;
            if(i==1){
                GameObject.Find("Ring").GetComponent<AudioSource>().Play();
                gameObject.SetActive(false);
            }}
        
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
