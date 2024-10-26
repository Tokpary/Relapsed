using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private Image _image;
    public Color _color;
    public float _fadeSpeed = 0.5f;
    public float _delay = 0f;
    public Ease E = Ease.Linear;
    
    private void Start()
    {
        _image = GetComponent<Image>();
        
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_image.DOColor(new Color(_color.r, _color.g, _color.b, 0), _delay));
        sequence.Append(_image.DOColor(new Color(_color.r, _color.g, _color.b, _color.a), _fadeSpeed)).SetEase(E);
        sequence.Play();
        
    }
    
    public void Fade()
    {
        _image.DOColor(new Color(_color.r, _color.g, _color.b, 0), 2).SetEase(E);
    }
}
