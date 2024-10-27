using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentManager : Singleton<EnvironmentManager>
{
    public Flowchart RamonFlowchart;
    public Flowchart[] Flowcharts;
    public GameObject[] DesktopPrefabs;
    public int Karma = 0;
    
    public Sprite[] DialogContent;
    public Sprite[] DialogButtons;
    
    public Button[] buttons;
    public Image DialogBox;
    
    public void InitializeKarma()
    {
        Karma += Flowcharts[0].GetIntegerVariable("KarmaJoel");
        Karma += Flowcharts[1].GetIntegerVariable("KarmaLeo");
        Karma += Flowcharts[2].GetIntegerVariable("KarmaAndrea");
        RamonFlowchart.SetIntegerVariable("KarmaGlobal", Karma / 3);
        //int karma = RamonFlowchart.GetVariable("KarmaGlobal");
    }
    
    private void Start()
    {
        InitializeKarma();
        //Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }

    public void UpdateEnvironment()
    {
        if (Karma >= 0 && Karma <= 100)
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[2];
            }
            DialogBox.sprite = DialogContent[2];
            Instantiate(DesktopPrefabs[4]);
        } else if (Karma > 100 && Karma <= 160)
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[1];
            }
            DialogBox.sprite = DialogContent[1];
            Instantiate(DesktopPrefabs[3]);
            
        } else if (Karma > 160 && Karma <= 200)
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[0];
            }
            DialogBox.sprite = DialogContent[0];
            Instantiate(DesktopPrefabs[2]);
            
        } 
    }
}
