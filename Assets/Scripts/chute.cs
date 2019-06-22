using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chute : MonoBehaviour {

    // Use this for initialization
    private string _informacao;
    public bool gol=false;
    public bool pressSpace = false;
    public static int contSpace = 0;

    void OnCollisionStay(Collider colisor)
    {
        Vector3 pos = transform.position;
        transform.position = pos;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "colisorRede")
        {
            gol = true;
            //_informacao = "GOOOLLLLL!!";
        }

       // this.transform.position = new Vector3(10, 10, 0);

    }
    void OnGUI()
    {
        GUI.Label(new Rect(100, 75, 200, 100), _informacao);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            pressSpace = true;
            contSpace++;
            
        }
        if (pressSpace && !gol && contSpace == 2 )
        {
            chutar();
        }
    }
    void chutar()
    {
        //chuteHorizontal c;
        //float a = c.getChuteX();
        float posy = (ChuteVertical.chuteY - 90)/9 + 4;
        float posx = (chuteHorizontal.chuteX - 90) / 4 - 20;
        Vector3 pos = transform.position;

        pos.x = pos.x - (posx * Time.deltaTime);
        pos.y = pos.y + (posy * Time.deltaTime);
        pos.z = pos.z - (30.0f * Time.deltaTime);
        transform.position = pos;

    }
}
