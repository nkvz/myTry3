using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCylinder : Object
{
    [Header("Set In Inspector")]
    public static bool IsSelected;
    private bool selected;
  
    public void OnMouseDown()
    {
        if (gameObject.tag == "objectCylinder")
        {
            selected = true;
            IsSelected = selected;
            ObjectCube.IsSelected = ObjectSphere.IsSelected = ObjectCapsule.IsSelected = false;
        }
    }

    public void Update()
    {
        if (IsSelected == true)
        {
            GetInput();
            Attack();
            ChangeColor();
            UltimateCylinder();
        }
    }

}
