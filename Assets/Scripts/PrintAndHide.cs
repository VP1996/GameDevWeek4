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
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(sph.name + ++i);
    }
}
