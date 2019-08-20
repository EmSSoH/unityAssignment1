using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            print("Respect");
        }
    }

    public void Botton1()
    {
        print("i have been clicked");
    }

    public GameObject shootingStar;
    
    public void Spawn()
    { 
        Instantiate(shootingStar);
    }
}
