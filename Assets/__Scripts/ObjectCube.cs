using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectCube : Object
{
    [Header("Set In Inspector")]
    public static bool IsSelected;
    private bool selected;

    public void OnMouseDown()
    {
        if(gameObject.tag == "objectCube")
        {
            selected = true;
            IsSelected = selected;
            ObjectSphere.IsSelected = ObjectCapsule.IsSelected = ObjectCylinder.IsSelected = false;
        } 
    }

    public void Update()
    {
        if(IsSelected == true)
        {
            GetInput();
            Attack();
            ChangeColor();
            UltimateCube();
        }
    }
}

