using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public enum ObjectType
{
    none,
    cube,
    sphere,
    capsule,
    cylinder
}

[System.Serializable]
public class ObjectDefinition
{
    public ObjectType type = ObjectType.none;
    public Color color = Color.white;
}


public class enums : MonoBehaviour
{
    [Header("Set In Inspector")]
    static public enums S;
    public static bool SelectedYep;

    public bool selectedCube;
    public bool selectedSphere;
    public bool selectedCapsule;
    public bool selectedCylinder;

    [Header("Set Dynamically")] [SerializeField]
    private ObjectType _type = ObjectType.none;
    public ObjectDefinition def;
    public GameObject collar;
    private Renderer collarRend;

    public void Start()
    {
        S = this;
        collarRend = collar.GetComponent<Renderer>();
        SetType(_type);
    }

    private void Update()
    {
        selectedCube = ObjectCube.IsSelected;
        selectedSphere = ObjectSphere.IsSelected;
        selectedCapsule = ObjectCapsule.IsSelected;
        selectedCylinder = ObjectCylinder.IsSelected;

        if (selectedCube || selectedSphere || selectedCapsule || selectedCylinder == true)
        {
            SelectedYep = true;
        }

        if (SelectedYep == true)
        {
            if (selectedCube == true)
            {
                SetType(type = ObjectType.cube);
                selectedSphere = selectedCapsule = selectedCylinder = false;
            }
            else if (selectedSphere == true)
            {
                SetType(type = ObjectType.sphere);
                selectedCube = selectedCapsule = selectedCylinder = false;
            }
            else if (selectedCapsule == true)
            {
                SetType(type = ObjectType.capsule);
                selectedCube = selectedSphere = selectedCylinder = false;
            }
            else if (selectedCylinder == true)
            {
                SetType(type = ObjectType.cylinder);
                selectedCube = selectedSphere = selectedCapsule = false;
            }
        }
        
    }

    public ObjectType type
    {
        get { return (_type); } 
        set { SetType(value); }
    }

    public void SetType(ObjectType ot)
    {
        _type = ot;

        /*
        if(type == ObjectType.none)
        {
            collarRend.material.color = Color.white; 
            return;
        } else
        {
            collarRend.material.color = Color.blue;
        }
        */
        //collarRend.material.color = def.color;
    }

}
