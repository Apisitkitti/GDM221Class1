using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject Obtacle;
    [SerializeField] float timedelay = 3f;
    [SerializeField] Transform spawn;
    
    float start =0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start > 0)
        {
            start -= 1;
        }
        if(start <=0)
        {
            Instantiate(Obtacle, spawn);
             start = timedelay;
        }
       

    }
}
