using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailBrakes : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem trail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null){
            trail.Stop();
        }
    }
}
