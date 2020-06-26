using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GroundManager : MonoBehaviour
{
    public bool CanJump;
    
    [SerializeField] public LayerMask Ground;
    void Update(){
        
    }
    void OnTriggerStay2D(Collider2D collision){
        
        CanJump = collision != null && (((1 << collision.gameObject.layer) & Ground) != 0);
    }
    void OnTriggerExit2D(Collider2D collision){
        CanJump = false;
    }
}
