using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrownScript : MonoBehaviour
{

    public ParticleSystem pork;
    public PlayerDeath death;
    
    public Transform player;
    public float oxygen;
    public float MaxOxygen;
    public bool Drowning;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        oxygen = MaxOxygen;        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Drowning){
            oxygen -= Time.deltaTime;
            
            if(!pork.isPlaying){
                pork.Play();
                
            }
        }else{
            
            if(oxygen < MaxOxygen){
                oxygen += Time.deltaTime;
                
            }else{
                oxygen = MaxOxygen;
                pork.Stop();
                
            }
        }

    }
    void OnTriggerEnter2D(){
        Drowning = true;
    }
    void OnTriggerExit2D(){
        Drowning = false;
    }
}
