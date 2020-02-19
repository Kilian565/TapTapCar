using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Malte
{
    private static string path;


    public static void LoadNewGame()
    {
        SceneManager.LoadScene("Ingame");
    }

    public static void LoadGame()
    {
        CreateDontDestroy.isNewGame = false;
        SceneManager.LoadScene("Ingame");
    }

}
