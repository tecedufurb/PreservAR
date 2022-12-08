using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AnimalBtn : MonoBehaviour
{
    public AnimalMenu menu;

    public VirtualButtonBehaviour button;

    public bool rightButton;

    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        menu.NextAnimal(rightButton);
    }
}
