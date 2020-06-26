using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public DrownScript drownie;

    public GameObject explosion;
    public bool dead = false;
    public float PostDeathTotal;
    public float PostDeathActual;
    public Manager Manager;
    public Transform PostTarget;

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
        PostDeathActual = PostDeathTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(dead){
            if(PostDeathActual > 0){
                PostDeathActual -= Time.deltaTime;
            }else{
                Manager.Mask.TargetScene = SceneManager.GetActiveScene().name;
                
                Manager.maskTarget.target = PostTarget;
                Manager.maskTarget.DefaultEnabled = false;
                Manager.Mask.shrinking = true;
            }
        }else{
            transform.position = player.transform.position;
            if(drownie.oxygen <= 0){
                Die();
            }
        }
    }
    void OnTriggerEnter2D(){
        Die();
    }
    public void Die(){
        GameObject explo = Instantiate(explosion, transform);
        explo.transform.position = transform.position;
        Destroy(player);
        player = null;
        drownie = null;
        dead = true;
    }
}
