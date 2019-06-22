using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChuteVertical : MonoBehaviour
{
    // Use this for initialization
    public bool ida = true;
    public bool space = false;
    public static float chuteY = 0;
 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (chuteY == 0)
        {
            SelecionarDirChute();
        }

    }

    void SelecionarDirChute()
    {
        Vector3 pos = transform.position;
        if (!space && chute.contSpace==1)
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

        }
        if (chute.contSpace == 2)
        {
            chuteY = pos.x;
            Debug.Log("Space key was pressed.");
            space = true;
        }

        transform.position = pos;
    }

}

