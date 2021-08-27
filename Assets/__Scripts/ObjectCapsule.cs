using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCapsule : Object
{
    [Header("Set In Inspector")]
    public static bool IsSelected;
    private bool selected;

    public int randNum;


    public void OnMouseDown()
    {
        if (gameObject.tag == "objectCapsule")
        {
            selected = true;
            IsSelected = selected;
            ObjectCube.IsSelected = ObjectSphere.IsSelected = ObjectCylinder.IsSelected = false;
            randNum = Random.Range(0, 3);
        }
    }

    public void Update()
    {
        if (IsSelected == true)
        {
            GetInput();
            Attack();
            ChangeColor();

            if (randNum == 0)
            {
                UltimateCube();
            }
            else if (randNum == 1)
            {
                UltimateSphere();
            }
            else if (randNum == 2)
            {
                UltimateCylinder();
            }
        }
    }
}
