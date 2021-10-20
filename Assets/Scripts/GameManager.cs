using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text statusPlayer;
    public GameObject playerStatusPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        
        Player player = new Player(MenuHandler.Instanciate.playerName);
        string stAlive = "";
        if (player.setAlive)
        {
            stAlive = "The Player is Alive";
        }
        statusPlayer.text = "Player Name: "+player.setName.ToString() + "\n Current Health:" + player.setHealth + "\n " + stAlive;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStatusPosition.transform.position.y < -20)
        {
            SceneManager.LoadScene(0);
        }

    }
}
