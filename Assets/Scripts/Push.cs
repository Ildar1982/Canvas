using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(Image))]
public class Push : MonoBehaviour, IPointerDownHandler
{
    private Image _imagePush;
    private AnimatorOn _anim;
    private void Start()
    {
        _imagePush = GetComponent<Image>();
        _anim = GetComponentInParent<AnimatorOn>();

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        _imagePush.color = Color.red;
        _anim.AnimationOn();
    }    
}
