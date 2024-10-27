using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;

public class EnvironmentManager : Singleton<EnvironmentManager>
{
    public Flowchart[] Flowcharts;
    public GameObject[] DesktopPrefabs;
    public int Karma = 0;
    
    private void Start()
    {
        
    }

    public void UpdateEnvironment()
    {
        
    }
}
