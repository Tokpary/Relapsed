using System;
using System.Collections;
using System.Collections.Generic;
using Code.Scripts.InteractableObjects;
using UnityEngine;
using UnityEngine.EventSystems;

public class CallManager : InteractableObject
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void PickUp()
    {
        GameManager.Instance.NextDialogue();
        audioSource.Stop();
    }
    
    public void Call()
    {
        audioSource.Play();
        
        Debug.Log("Calling...");
    }
    
    public void Answer()
    {
        Debug.Log("Answering...");
    }
    
    public void HangUp()
    {
        Debug.Log("Hanging up...");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("PickUp...");
        PickUp();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
