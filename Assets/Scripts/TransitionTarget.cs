using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTarget : MonoBehaviour
{
    public bool DefaultEnabled;
    public string DefaultTarget;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DefaultEnabled){
            if(GameObject.FindGameObjectWithTag(DefaultTarget) != null){
                transform.position = GameObject.FindGameObjectWithTag(DefaultTarget).transform.position;

            }
        }else{
            if(target != null){
                transform.position = target.position;
            }
        }


    }
}
