using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class FadeOutText : MonoBehaviour
{
    private TMP_Text _text;
    public Color _color;
    public float _fadeSpeed = 0.5f;
    
    private void Start()
    {
        _text = GetComponent<TMP_Text>();
    }
    
    public void Fade()
    {
        _text.material.DOColor(new Color(_color.r, _color.g, _color.b, 0), _fadeSpeed);
    }
}