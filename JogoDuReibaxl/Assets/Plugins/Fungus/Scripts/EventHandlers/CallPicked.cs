using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System;
using System.Diagnostics;
using Unity.VisualScripting.YamlDotNet.Serialization.NodeDeserializers;

public class CallPicked : MonoBehaviour
{
    public Flowchart flowchart;
    public List<Flowchart> calls;
    private bool _callPicked;
    private int ID;

    // Start is called before the first frame update
    void Start()
    {
        calls = new List<Flowchart>();
        flowchart.SetBooleanVariable("CallPickedUP", false);
        flowchart.SetBooleanVariable("PhoneRinging", true);
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnMouseDown()
    {
        if (flowchart.GetBooleanVariable("PhoneRinging"))
        {
            flowchart.SetBooleanVariable("CallPickedUP", true);
            flowchart.SendFungusMessage("Picked");
            //flowchart.SetBooleanVariable("PhoneRinging", false);
        }

    }

    
    




}
