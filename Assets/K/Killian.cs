using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killian
{
    public static void ScrapyardClick()
    {
        int random = Random.Range(0, 101);
        int[] dropchances = new int[2] {25,50};
        
        //int dropchancePlastic = 25;
        //int dropchanceElectronics = 50;

        Variables.resScraps = Variables.resScraps + (1 * Variables.clickMultiplier);

        if (random >= dropchances[0])
        {
            Variables.resPlastics = Variables.resPlastics + (1 * Variables.clickMultiplier);
        }
        if (random >= dropchances[1])
        {
            Variables.resElectronics = Variables.resElectronics + (1 * Variables.clickMultiplier);
        }

    }




}
