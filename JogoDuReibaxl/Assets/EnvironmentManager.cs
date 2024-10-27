using System;
using System.Collections;
using System.Collections.Generic;
using Code.Scripts.InteractableObjects;
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
    
    public GameObject currentDesktop;
    
    //0 en curso
    //1 completado
    //2 fallido
    public int AlexState = 0;
    public int LeoState = 0;
    public int AndreaState = 0;
    public int RamonState = 0;
    public int JoelState = 0;
    
    public GameObject[] PostIts;
    public GameObject[] Letters;
    
    [SerializeField]InteractableLetterTrayWithCarrousel letterTray;
    
    public void InitializeKarma()
    {
        Karma += Flowcharts[0].GetIntegerVariable("KarmaJoel");
        Karma += Flowcharts[1].GetIntegerVariable("KarmaLeo");
        Karma += Flowcharts[2].GetIntegerVariable("KarmaAndrea");
        Karma = Karma / 3;
        RamonFlowchart.SetIntegerVariable("KarmaGlobal", Karma);
        //int karma = RamonFlowchart.GetVariable("KarmaGlobal");
    }
    
    private void Start()
    {
        InitializeKarma();
        //Flowcharts[CurrentDay - 1].ExecuteBlock("TutorialPresentacion");
    }
    
    public void SetAlexCompleted()
    {
        AlexState = 1;
    }
    public void SetLeoCompleted()
    {
        LeoState = 1;
    }
    public void SetAndreaCompleted()
    {
        AndreaState = 1;
    }
    public void SetRamonCompleted()
    {
        RamonState = 1;
    }
    public void SetJoelCompleted()
    {
        JoelState = 1;
    }
    
    public void SetAlexFailed()
    {
        AlexState = 2;
    }
    public void SetLeoFailed()
    {
        LeoState = 2;
    }
    public void SetAndreaFailed()
    {
        AndreaState = 2;
    }
    public void SetRamonFailed()
    {
        RamonState = 2;
    }
    public void SetJoelFailed()
    {
        JoelState = 2;
    }
    

    public void UpdateEnvironment()
    {
        int completed = 0;
        if(AlexState == 1)
        {
            PostIts[4].SetActive(true);
            completed++; 
        }
        if(LeoState == 1)
        {
            Letters[0].SetActive(true);
            Letters[1].SetActive(true);
            letterTray.AddLetter(3);
            letterTray.AddLetter(4);
            PostIts[0].SetActive(true);
            completed++;
        }
        if(AndreaState == 1)
        {
            if(Flowcharts[2].GetVariable("Nombre").ToString().Equals("Alex"))
            {
                letterTray.AddLetter(1);
            }
            {
                letterTray.AddLetter(0);
            }
            Letters[2].SetActive(true);
            PostIts[3].SetActive(true);
            completed++;
        } 
        if(RamonState == 1)
        {
            letterTray.AddLetter(5);
            Letters[3].SetActive(true);
            PostIts[2].SetActive(true);
            completed++;
        }
        if(JoelState == 1)
        {
            letterTray.AddLetter(2);
            Letters[4].SetActive(true);
            PostIts[1].SetActive(true);
            completed++;
        }
        
        if(completed >= 2)
        {
            completed = 2;
        }

        GameObject.Destroy(currentDesktop);
        if (Karma <= 100)
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[2];
            }
            DialogBox.sprite = DialogContent[2];
            //Instantiate as child
            currentDesktop = Instantiate(DesktopPrefabs[4 - completed], transform.position, Quaternion.identity);
        } else if (Karma > 100 && Karma <= 160)
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[1];
            }
            DialogBox.sprite = DialogContent[1];
            currentDesktop = Instantiate(DesktopPrefabs[3- completed], transform.position, Quaternion.identity);
            
        } else 
        {
            foreach (var button in buttons)
            {
                button.image.sprite = DialogButtons[0];
            }
            DialogBox.sprite = DialogContent[0];
            currentDesktop = Instantiate(DesktopPrefabs[2 - completed], transform.position, Quaternion.identity);
            
        } 
        
        
    }
}
