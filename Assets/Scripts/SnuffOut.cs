using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnuffOut : MonoBehaviour
{
    public GameObject Light;
    public GameObject Particles;
    public Transform player;
    public float SnuffDistance;
    public Vector3 PlayerDistance;
    public bool SuperLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            PlayerDistance = player.position - transform.position;
            if(!SuperLight){
                Snuff();

            }else{

            }
        }
        
        
    }
    public void Snuff(){
        if(PlayerDistance.sqrMagnitude < SnuffDistance * SnuffDistance && Light != null){
            Light.GetComponent<LightFade>().lit = false;
            if(Light.GetComponent<CircleCollider2D>()){
                Light.GetComponent<CircleCollider2D>().enabled = false;
            }
            
            Light = null;
            Particles.GetComponent<ParticleSystem>().Stop();
        }
    }
}
