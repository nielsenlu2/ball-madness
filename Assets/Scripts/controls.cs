using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class controls : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    protected bool Pressed;

    // Update is called once per frame
    void Update()
    {

    }

    //when screen pressed, moves.
    public void OnPointerDown(PointerEventData eventData)
    {

      Pressed = true;
    }

    //when not pressed, doesn't move.
    public void OnPointerUp(PointerEventData eventData){
      Pressed = false;
    }

}
