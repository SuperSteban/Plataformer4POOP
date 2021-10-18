using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player(MenuHandler.Instanciate.playerName);
        Debug.Log(player.setName.ToString()+" Su salud es:"+ player.setHealth +" Esta vivo"+ player.setAlive);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
