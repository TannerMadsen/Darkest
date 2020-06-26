using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    public string TargetScene;
    public float Speed;
    public float targetSize;
    public bool shrinking;
    public bool growing;
    public Manager Manager;
    
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
        growing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(growing){
            Manager.maskTarget.DefaultEnabled = true;
            Manager.maskTarget.target = null;
            shrinking = false;
            if(transform.localScale.x < targetSize){
                transform.localScale += new Vector3(Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }else{
                transform.localScale = new Vector3(targetSize, targetSize, 1);
                growing = false;
            }
        }
        if(shrinking){
            if(transform.localScale.x >= 0.01){
                transform.localScale -= new Vector3(Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }else{
                transform.localScale = new Vector3(0,0,1);
                SceneManager.LoadScene(TargetScene);
                growing = true;
                shrinking = false;
                

            }
        }
    }
    
}
