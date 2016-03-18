using UnityEngine;
using System.Collections;

public class keepAlive : MonoBehaviour {

 
 
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
 




}
