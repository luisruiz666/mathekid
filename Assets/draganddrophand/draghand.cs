﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class draghand : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public GameObject itemDragging;

    Vector3 startPosition;
    Transform startPrent;
    Transform dragParent;
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("dragParent").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

   
   

   
    void Update()
    {
        
    }
}
