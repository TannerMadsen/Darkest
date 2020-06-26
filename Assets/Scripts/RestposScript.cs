using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestposScript : MonoBehaviour
{
    public Transform player;
    public PlayerMovement movie;
    public float ExtraHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            if(movie.groundie.CanJump){
                transform.position = new Vector3(player.position.x, player.position.y + ExtraHeight, transform.position.z);
            }
            else{
                transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
            }
        }
    
    }
}
