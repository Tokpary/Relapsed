using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartFadeOut : MonoBehaviour
{  
    private Image _image;
    public float _fadeSpeed = 2f;
    
    private void Start()
    {
        _image = GetComponent<Image>();
        _image.DOColor(new Color(0,0,0, 0), _fadeSpeed).SetEase(Ease.InQuad);
    }
    
    public void Fade()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_image.DOColor(new Color(0,0,0, 1), 3f).SetEase(Ease.InSine).SetDelay(1f));
        sequence.AppendInterval(2f);
        sequence.AppendCallback(() => SceneManager.LoadScene(1));
    }
}
