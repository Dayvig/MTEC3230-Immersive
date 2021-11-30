using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class ClickColor : MonoBehaviour
{
    private Renderer thisRenderer;
    private Color thisColor = Color.white;
    
    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateColor()
    {
        RaycastHit Hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out Hit, 1000f))
        {
            if (Hit.transform != null)
            {
                Debug.Log("Test");
                thisColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 1f);
                thisRenderer.material.color = thisColor;
            }
        }
    }

}
