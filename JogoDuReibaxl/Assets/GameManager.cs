using System.Collections;
using System.Collections.Generic;
using Code.Scripts;
using Fungus;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int CurrentDay { get; private set; } = 1;
    public int CurrentDialogue { get; private set; } = 0;
    public Flowchart[] Flowcharts;
    public bool IsFirstCall = true;
    
    public void NextDay()
    {
        CurrentDay++;
        CurrentDialogue = 0;
        Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }
    
    public void DismissCall()
    {
        Flowcharts[CurrentDialogue].ExecuteBlock("DoesntPickUp");
        CurrentDialogue++;
    }
    
    public void PickUpCall()
    {
        if(IsFirstCall)
        {
            IsFirstCall = false;
            Flowcharts[CurrentDialogue].ExecuteBlock("TutorialPresentacion");
            return;
        }
        Flowcharts[CurrentDialogue].ExecuteBlock("PickUp");
        CurrentDialogue++;
    }

    public void PlayDialogue(int dialogue)
    {
        Flowcharts[dialogue].ExecuteBlock("TutorialPresentacion");
    }

    
    private void Start()
    {
        CallManager.Instance.Call();
       // Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }
}
