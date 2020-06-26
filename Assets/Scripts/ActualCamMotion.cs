using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualCamMotion : MonoBehaviour
{
    public Transform CamTarget;
    public Rigidbody riggity;
    private Vector3 move;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = CamTarget.position - transform.position;
        riggity.velocity = move * speed;

    }
}
