using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text _text;
    
    public void DisplayDay()
    {
        _text.gameObject.SetActive(true);
        _text.text = "DÍA " + GameManager.Instance.CurrentDay.ToString();
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.transform.DOPunchScale(new Vector3(0.9f, 0.9f, 0.9f), 0.5f, 2, 1));
        sequence.AppendInterval(3);
        sequence.OnComplete(() =>
        {
            _text.gameObject.SetActive(false);
        });
        sequence.Play();
    }
}
