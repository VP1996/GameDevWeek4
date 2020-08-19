using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;

    public GameObject sph;

    public Renderer rend;


    void Start()
    {


    }


    void Update()
    {
        ++i;
        Debug.Log(sph.name + i);
        if (i == 100 && sph.tag == "Red") 
        { 
            sph.SetActive(false);
        }

        if( sph.tag == "Blue" && i == Random.Range(200, 251))
        {
            rend.enabled = false;
        }
    }
}
