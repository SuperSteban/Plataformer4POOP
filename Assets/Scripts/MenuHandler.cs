using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public string playerName;
    
    [SerializeField]  InputField inputName;
    public static MenuHandler Instanciate;


    private void Awake()
    {
        Instanciate = this;
        DontDestroyOnLoad(this);


    }

    public void SetName() 
    {
        playerName = inputName.text;
        
    }
    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }
}
