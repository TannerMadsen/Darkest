using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LightCounterScript : MonoBehaviour
{
    public List<SnuffOut> Lights;
    public Text Report;
    public Manager Manager;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        for(int i = Lights.Count -1; i>=0; i--){
            /*if(Input.GetKey(KeyCode.O)){
                Lights[i].Light = null;
            }*/
            if(Lights[i].Light == null){
                Lights[i] = Lights[Lights.Count - 1];
                Lights.RemoveAt(Lights.Count -1);
            }
        }
        
        Report.text = Lights.Count.ToString();
        if(Lights.Count <= 0){
            Manager.Mask.TargetScene = "Finish";
            Manager.maskTarget.target = player;
            Manager.maskTarget.DefaultEnabled = false;
            Manager.Mask.shrinking = true;
            Manager.Mask.targetSize = 20;
        }
    }
}
