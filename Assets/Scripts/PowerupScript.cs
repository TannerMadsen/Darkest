using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupScript : MonoBehaviour
{
    public SnuffOut[] Lights;
    public Text textie;
    public bool ShowText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShowText){
            if(textie.color.a < 1){
                textie.color += new Color (0,0,0,Time.deltaTime);
            }else{
                textie.color = new Color(255,255,255,255);
                ShowText = false;
            }
        }
    }
    void OnTriggerEnter2D(){
        Activate();
    }
    public void Activate(){
        ShowText = true;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        this.gameObject.GetComponentInChildren<ParticleSystem>().Stop();
        this.gameObject.GetComponentInChildren<UnityEngine.Experimental.Rendering.Universal.Light2D>().enabled = false;
        foreach (SnuffOut snuffie in Lights){
            snuffie.SuperLight = false;
            snuffie.gameObject.layer = 10;
        }

    }
}
