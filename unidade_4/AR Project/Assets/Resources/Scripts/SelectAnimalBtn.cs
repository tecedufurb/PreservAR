using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SelectAnimalBtn : MonoBehaviour
{
    public AnimalMenu menu;

    public VirtualButtonBehaviour button;

    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        menu.SelectAnimal();
    }
}
