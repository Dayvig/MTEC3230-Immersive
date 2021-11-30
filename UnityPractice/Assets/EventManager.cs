using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventManager : EventTrigger
{
    public override void OnBeginDrag(PointerEventData data)
        {
        }

        public override void OnCancel(BaseEventData data)
        {
        }

        public override void OnDeselect(BaseEventData data)
        {
        }

        public override void OnDrag(PointerEventData data)
        {
        }

        public override void OnDrop(PointerEventData data)
        {
        }

        public override void OnEndDrag(PointerEventData data)
        {
            Debug.Log("OnEndDrag called.");
        }

        public override void OnInitializePotentialDrag(PointerEventData data)
        {
            Debug.Log("OnInitializePotentialDrag called.");
        }

        public override void OnMove(AxisEventData data)
        {
            Debug.Log("OnMove called.");
        }

        public override void OnPointerClick(PointerEventData data)
        {
            Debug.Log("OnPointerClick called.");
        }

        public override void OnPointerDown(PointerEventData data)
        {
            Debug.Log("OnPointerDown called.");
        }

        public override void OnPointerEnter(PointerEventData data)
        {
            Debug.Log("OnPointerEnter called.");
        }

        public override void OnPointerExit(PointerEventData data)
        {
            Debug.Log("OnPointerExit called.");
        }

        public override void OnPointerUp(PointerEventData data)
        {
            Debug.Log("OnPointerUp called.");
        }

        public override void OnScroll(PointerEventData data)
        {
            Debug.Log("OnScroll called.");
        }

        public override void OnSelect(BaseEventData data)
        {
            Debug.Log("OnSelect called.");
        }

        public override void OnSubmit(BaseEventData data)
        {
            Debug.Log("OnSubmit called.");
        }

        public override void OnUpdateSelected(BaseEventData data)
        {
            Debug.Log("OnUpdateSelected called.");
        }
    }
