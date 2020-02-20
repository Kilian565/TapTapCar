using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum SortOfPart
{
    Frame,
    Tire,
    Engine,

}
public class Part
{
    //**// parts müssen hergestellt werden, bringen erfahrung, als klasse dargestellt, da sich durch verändern
    //**// des lvls die needs verändern
    //**// Scriptable objects? upgraden der teile für mehr geld? Enum um zu bestimmen welche art von Teil?
    //**// Klasse Car Part-Variablen geben? durch klicken auf garage, öffnet sich Fenster mit verfügbaren autos,
    //**// bei klick werden sie bei ausreichend vorhandenen teilen hergestellt
    //**// Auto zeigen ihren ihren "Fenstern" requirements an, grafische Darstellung des parts und anzahl



    //**// UPDATE: Car sollten scriptable objects sein, können dadurch in einer großen datenbank gespeichert werden
    //**// ausgelesen werden mit ihren dazugehörigen werten (requirments)
    //**// dadurch können viele verschiedene auto kombinationen erstellt werden, mit unterschiedlichen needs



    public int requiredScrap;
    public int requiredPlastics;
    public int requiredElectronics;
    public SortOfPart sort;

    public int level;

    public Button button;

    public Part(int _requiredScrap,
                int _requiredPlastics,
                int _requiredElectronics,
                SortOfPart _sort,
                Button _button)
    {
        this.requiredScrap = _requiredScrap;
        this.requiredPlastics = _requiredPlastics;
        this.requiredElectronics = _requiredElectronics;
        this.button = _button;
        this.sort = _sort;


        if (this.sort == SortOfPart.Engine)
        {
            this.level = Variables.engineLevel;
            Variables.carValueMultiplier = Variables.carValueMultiplier + (0.25f * this.level);
        }


        if (this.sort == SortOfPart.Frame)
        {
            this.level = Variables.frameLevel;
            Variables.carValueMultiplier = Variables.carValueMultiplier + (0.25f * this.level);
        }


        if (this.sort == SortOfPart.Tire)
        {
            this.level = Variables.tireLevel;
            Variables.carValueMultiplier = Variables.carValueMultiplier + (0.25f * this.level);
        }


        



    }





}
