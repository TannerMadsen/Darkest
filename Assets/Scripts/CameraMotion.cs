using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    public Transform Restpos;
    public PlayerDeath death;
    public float MotionFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!death.dead){
            transform.position = new Vector3 (Restpos.position.x + Input.GetAxis("Horizontal") * MotionFactor, Restpos.position.y, 0);
        }
        
    }
}
