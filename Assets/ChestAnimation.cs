using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ChestAnimation : MonoBehaviour
{

    public GameObject chestLid;

    void Start()
    {
        Sequence chestSequence = DOTween.Sequence();
        //first anim
        chestSequence.Append(transform.DOMoveY(5, 0.35f)).SetEase(Ease.InSine);
        chestSequence.Join(transform.DORotate(Vector3.up*180, 0.35f));
        //second anim
        chestSequence.Append(transform.DOMoveY(0, 0.50f));
        chestSequence.Join(transform.DORotate(Vector3.up*360, 0.50f)).SetEase(Ease.OutBack);
        //third anim
        chestSequence.Append(transform.DOShakeRotation(2f, 20f, 20, 3f));
        chestSequence.Join(transform.DOScaleY(transform.localScale.y*1.25f, 2f));
        //fourth anim
        chestSequence.Append(chestLid.transform.DORotate(Vector3.left * 125, 3f));
        chestSequence.Join(transform.DOScaleY(transform.localScale.y/1.25f, 2f));
    }


    void Update()
    {
        
    }
}
