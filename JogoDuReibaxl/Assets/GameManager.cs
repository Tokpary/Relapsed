using System.Collections;
using System.Collections.Generic;
using Fungus;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int CurrentDay { get; private set; } = 1;
    public int CurrentDialogue { get; private set; } = 0;
    public Flowchart[] Flowcharts;
    
    public void NextDay()
    {
        CurrentDay++;
        CurrentDialogue = 0;
        Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }

    public void NextDialogue()
    {
        Flowcharts[CurrentDialogue].ExecuteBlock("TutorialPresentacion");
        CurrentDialogue++;
    }
    
    private void Start()
    {
       // Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }
}
