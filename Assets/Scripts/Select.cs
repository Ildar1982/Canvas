using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(Image))]
public class Select : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    private Image _imageSelect;    
    private void Start()
    {
        _imageSelect = GetComponent<Image>();
        
    }
    public void OnPointerEnter (PointerEventData eventData)
    {
        _imageSelect.color = Color.blue;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _imageSelect.color = Color.white;
    }
}
