using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour {
    public GameObject core;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

      
        void OnMouseDown()
        {
        core.GetComponent<GamesController>().Repeat = 1;
        GetComponent<TextMesh>().color = Color.red;
         }
         void OnMouseExit()
        {
        GetComponent<TextMesh>().color = Color.black;
    }
}
