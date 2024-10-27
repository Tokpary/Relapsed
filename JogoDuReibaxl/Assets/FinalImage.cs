using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class FinalImage : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Sprite _letter;
    [SerializeField] private Sprite _article;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void DisplayArticle()
    {
        GetComponent<SpriteRenderer>().sprite = _article;
        gameObject.SetActive(true);
    }
    
    public void DisplayLetter()
    {
        GetComponent<SpriteRenderer>().sprite = _article;
        gameObject.SetActive(true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Ending");
    }
}
