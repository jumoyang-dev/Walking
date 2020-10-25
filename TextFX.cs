using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TextMeshPro))]
public class TextFX : MonoBehaviour {

    
private TextMeshPro textMesh;
public string[] textCharacter;
public bool isActive;
public float timeInSeconds;
float timer;
int charCount;

void Start () {


        textMesh = gameObject.GetComponent<TextMeshPro>();
        textCharacter= new string[textMesh.text.Length];
        for (int i=0;i<textMesh.text.Length;i++){
            textCharacter[i]=textMesh.text.Substring(i,1);
        }
        textMesh.text="";
        charCount=0;
        timer=0;


}

void Update(){


    
    if(isActive){ 
        gameObject.GetComponent<TextMeshPro>().enabled=true;
        
        if(charCount<textCharacter.Length){
            timer+=Time.deltaTime;
            if(timer>=timeInSeconds){
                textMesh.text+=textCharacter[charCount];
                charCount++;
                timer=0;
            }
        }
        if(charCount==textCharacter.Length){
            if(transform.childCount>0){
                transform.GetChild(0).GetComponent<TextFX>().isActive=true;
                charCount++;
            }
        }

    
    }

   else{
       gameObject.GetComponent<TextMeshPro>().enabled=false;
   } 
}
void OnTriggerEnter(Collider col){
    if(col.tag=="Player"){
        
       
            isActive=true;
           
        
    }
}

void OnTriggerExit(Collider col){
    if(col.tag=="Player"){

        
        isActive=false;
    }
}
}