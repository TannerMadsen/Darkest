using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFade : MonoBehaviour
{
    public bool lit = true;
    public float snuffspeed;
    public UnityEngine.Experimental.Rendering.Universal.Light2D Litboi;
    
    // Start is called before the first frame update
    
    void Update(){
        if(!lit){
            Litboi.pointLightOuterRadius -= Time.deltaTime * snuffspeed;
            Litboi.intensity -= Time.deltaTime * snuffspeed;
            if(Litboi.pointLightOuterRadius <= 0){
                Destroy(this.gameObject);
            } 

        }
        
    }

}
