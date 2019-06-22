using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour {

    private string _informacao;


    void OnTriggerEnter(Collider colisor)
    {
        _informacao = "GOOOOOOOOOOOOOOLLL ";
        Vector3 pos = transform.position;
        transform.position = pos;
    }

    /*void OnTriggerStay(Collider colisor)
    {
        _informacao = "GOOOOOOOOOOOOOOOOLLL";
    }
    */

    void OnTriggerExit(Collider colisor)
    {
        _informacao = "";
    }

    void OnGUI()
    {
        GUI.Label(new Rect(100, 75, 200, 100), _informacao);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
