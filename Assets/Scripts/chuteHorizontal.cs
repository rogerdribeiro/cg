using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chuteHorizontal : MonoBehaviour {
    // Use this for initialization
    public bool ida = true;
    public bool space = false;
    public static float chuteX = 0;

    void Start() {
   
    }

    // Update is called once per frame
    void Update() {
        if(chuteX == 0)
        {
            selecionarDirChute();
        }
     }

    void selecionarDirChute()
    {
        Vector3 pos = transform.position;
        if (!space)
        {
            if (ida)
            {
                if (pos.x <= 260)
                {
                    pos.x = pos.x + 1;
                }
                else
                {
                    ida = false;
                }
            }
            if (!ida)
            {
                if (pos.x > 90)
                {
                    pos.x = pos.x - 1;
                }
                else
                {
                    ida = true;
                }
            }
            MonoBehaviour.print(pos);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = true;
            chuteX = pos.x;
        }
        Debug.Log("Space key was pressed.");
        MonoBehaviour.print(pos);
   
        transform.position = pos;
    }
}
   
