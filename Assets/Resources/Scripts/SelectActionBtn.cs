using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SelectActionBtn : MonoBehaviour
{
    public ActionMenu menu;

    public VirtualButtonBehaviour button;

    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        menu.SelectAction();
    }
}
