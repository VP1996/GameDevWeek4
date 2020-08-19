using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public int i;

    public GameObject sph;




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
