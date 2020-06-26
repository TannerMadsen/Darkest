using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Manager Manager;
    // Start is called before the first frame update
    void Start(){
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        
    }
    public void Play(){       
        Manager.Mask.targetSize = 36;
        Manager.Mask.TargetScene = "Scene1";
        Manager.Mask.shrinking = true;
    }
    public void Info(){       
        Manager.Mask.targetSize = 20;
        Manager.Mask.TargetScene = "Info";
        Manager.Mask.shrinking = true;
    }
    public void Menu(){
           
        Manager.Mask.targetSize = 20;
        Manager.Mask.TargetScene = "MainMenu";
        Manager.Mask.shrinking = true;
    
    }
    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit!");
    }
}
