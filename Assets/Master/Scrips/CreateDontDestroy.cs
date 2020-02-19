using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gamestate
{
    mainMenu,
    ingame
}

public class CreateDontDestroy : MonoBehaviour
{

    private GameObject logic;
    private static CreateDontDestroy instance;

    public static Gamestate CurrentGamestate;
    public static bool isNewGame = true;


    private void Awake()
    {
        logic = this.gameObject;
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        CurrentGamestate = Gamestate.mainMenu;
    }


    private void AudioManager()
    {
        if (CurrentGamestate == Gamestate.mainMenu)
        {
            //play main menu music
        }
        if (CurrentGamestate == Gamestate.ingame)
        {
            //play background music
        }
    }

    public void NewGame()
    {
        Malte.LoadNewGame();
    }
    public void LoadGame()
    {
        Malte.LoadGame();
    }

}
