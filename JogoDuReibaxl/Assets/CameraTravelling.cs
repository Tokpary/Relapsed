using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CameraTravelling : MonoBehaviour
{
    public Vector3[] _positions;
    public Vector3[] _rotations;
    public float[] _durations;
    public Ease[] _eases;
    public GameObject OfficeLigth;
    public StartFadeOut StartFadeOut;
    
    
    public void StartTravelling()
    {
        StartNextTravelling(0);
    }
    
    private void StartNextTravelling(int i)
    {
        if (i == 10)
        {
            OfficeLigth.SetActive(true);
        } else if (i == 12)
        {
            StartFadeOut.Fade();
        }
        transform.DOMove(_positions[i], _durations[i]).SetEase(_eases[i]);
        transform.DORotate(_rotations[i], _durations[i]).SetEase(_eases[i]).OnComplete(() =>
        {
            if (i + 1 >= _positions.Length)
            {
                return;
            }
            StartNextTravelling(i + 1); 
        });
       
    }
    
    

    private void Start()
    {
        transform.position = _positions[0];
        transform.rotation = Quaternion.Euler(_rotations[0]);
    }
}
