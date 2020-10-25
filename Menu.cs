using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public bool InActive;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame

    void FixedUpdate(){
        
        if(Input.GetKeyDown(KeyCode.Escape)){

            CallMenu();
            InActive=true;
        }


    }
    void CallMenu()
    {

          transform.Find("MenuPanel").gameObject.SetActive(true);

          Time.timeScale=0.0f;
        }
    
    public void Quit(){

        Application.Quit();

    }

    public void Resume(){

        transform.Find("MenuPanel").gameObject.SetActive(false);

        Time.timeScale=1.0f;


    }

        
    
}
