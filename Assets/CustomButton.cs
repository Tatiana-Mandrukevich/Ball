using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool IsPressed;
    public bool IsButtonDown;
    public bool IsButtonUp;
    
    public KeyCode PressedKey;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        IsPressed = true;
        IsButtonDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsPressed = false;
        IsButtonUp = true;
    }

    private void Update()
    {
        IsPressed = Input.GetKey(PressedKey);
        IsButtonUp = Input.GetKeyUp(PressedKey);
        IsButtonDown = Input.GetKeyDown(PressedKey);
    }

    private void LateUpdate()
    {
        IsButtonDown = false;
        IsButtonUp = false;
    }
}