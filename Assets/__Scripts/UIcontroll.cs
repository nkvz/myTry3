using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroll : MonoBehaviour
{
    [Header("Set In Inspector")]
    public GameObject panelHint;
    public bool openedHint = true;

    public void Update()
    {
        VisibleHint();
    }

    public void VisibleHint()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(openedHint)
            {
                CloseHint();
            } else
            {
                OpenHint();
            }
        }
    }

    private void CloseHint()
    {
        openedHint = false;
        panelHint.SetActive(false);
    }

    private void OpenHint()
    {
        openedHint = true;
        panelHint.SetActive(true);
    }
}
