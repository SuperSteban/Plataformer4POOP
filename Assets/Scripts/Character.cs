using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    //this class provides the essential funtionalities and atributes for a character

    //Encapsulated atributes
    public string setName { get; set; }
    public bool setAlive { get; set; }
    public float setHealth{get; set;}

    //methods
    protected abstract string sayHi();

    


}
