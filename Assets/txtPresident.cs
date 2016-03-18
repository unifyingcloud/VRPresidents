using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class txtPresident : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

 GameObject persistentGameObject = GameObject.Find("objPresidents");
if (persistentGameObject!=null)
        { 
       PresidentsScript persistentScript = persistentGameObject.GetComponent<PresidentsScript>();

      if (persistentScript != null)
      GetComponent<Text>().text =persistentScript.selectedPresident;
            }

        //     t.text = persistentScript.sele;
    }


    





}
