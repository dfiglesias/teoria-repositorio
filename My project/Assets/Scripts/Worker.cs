using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : Person
{
    public string workNumber;
    public string empresa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetWorkNumber(string input)
    {
        workNumber = input;
    }

    public void SetEmpresa(string input)
    {
        empresa = input;
    }

    public override void PerformAction()
    {
        Debug.Log("I work in " + empresa + ", with code " + workNumber);
    }
}
