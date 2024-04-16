using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public string hobby;
    public string ciudad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHobby(string input)
    {
        hobby = input;
    }

    public void SetCiudad(string input)
    {
        ciudad = input;
    }

    public override void PerformAction()
    {
        Debug.Log("Hey, my hobby is: " + hobby + ", and I live in " + ciudad);
    }
}
