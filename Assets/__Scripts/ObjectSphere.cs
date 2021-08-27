using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSphere : Object
{
    [Header("Set In Inspector")]
    public static bool IsSelected;
    private bool selected;



    public void OnMouseDown()
    {
        if (gameObject.tag == "objectSphere")
        {
            selected = true;
            IsSelected = selected;
            ObjectCube.IsSelected = ObjectCapsule.IsSelected = ObjectCylinder.IsSelected = false;
        }
    }

    public void Update()
    {
        if (IsSelected == true)
        {
            GetInput();
            Attack();
            ChangeColor();
            UltimateSphere();
        }
    }
}
