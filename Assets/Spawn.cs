using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject Obtacle;
    [SerializeField] float timedelay = 10f;
    [SerializeField] Transform spawn;
    private float randomOfset = 5f;
    
    float start =0f;


    // Update is called once per frame
    void Update()
    {
       
        if(start <=0)
        {
            Instantiate(Obtacle, spawn);
            start = timedelay;
        }
         else
        {
            start -= 1*Time.deltaTime;
        }
       

    }
    void GetRandom()
    {

    }
}
