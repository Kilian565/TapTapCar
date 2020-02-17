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
    GameObject logic;
    static CreateDontDestroy instance;
    public static Gamestate CurrentGamestate;


    void Awake()
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


    public void AudioManager()
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

}
