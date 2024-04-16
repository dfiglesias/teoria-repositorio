using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    //ENCAPSULATION
    private new string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //ENCAPSULATION
    private string surname;
    public string Surname
    {
        get { return surname; }
        set{ surname = value; }
    }


    //ENCAPSULATION
    private string dni;
    public string Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName(string input)
    {
        Name = input;
    }

    public void SetSurname(string input)
    {
        Surname = input;

    }

    public void SetDNI(string input)
    {
        Dni = input;
    }

    public virtual void ShowGenrealData()
    {
        Debug.Log("I'm " + Name + " " + Surname + ", with dni " + Dni);
    }

    public abstract void PerformAction();
}
