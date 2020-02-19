using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Killian
{

    public static void ScrapyardClick()
    {
        Variablen.resScraps = Variablen.resScraps * Variablen.clickMultiplier;

        if (Random.Range(0, 101) > 25)
        {
            Variablen.resPlastic = Variablen.resPlastic * Variablen.clickMultiplier;
        }

        if (Random.Range(0, 101) > 50)
        {
            Variablen.resElectronics = Variablen.resElectronics * Variablen.clickMultiplier;
        }

    }
}
