using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:Character
{
    /*public string playerName;
    public bool playerisAlive;
    public string playerHp;*/
  




    public Player(string Name)
    {
        setName = Name;
        setAlive = true;
        setHealth = 100;
    }


    

    protected override string sayHi()
    {
        throw new System.NotImplementedException();
    }
}
