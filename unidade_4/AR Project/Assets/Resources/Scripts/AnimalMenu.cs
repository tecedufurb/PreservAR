using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMenu : MonoBehaviour
{
    public InfoPanel infoPanel;
    public ActionController actionController;

    public List<GameObject> animalsMenu = new List<GameObject>();
    public List<GameObject> animalsMap = new List<GameObject>();

    public int idSelectedAnimal = -1;

    private int idAnimal = 0;

    public void NextAnimal(bool right)
    {
        animalsMenu[idAnimal].SetActive(false);

        if (right)
        {
            if (++idAnimal == animalsMenu.Count)
                idAnimal = 0;
        }
        else
        {
            if (--idAnimal == -1)
                idAnimal = animalsMenu.Count - 1;
        }

        animalsMenu[idAnimal].SetActive(true);
    }

    public void SelectAnimal()
    {
        infoPanel.ResetPanel();
        actionController.ResetActualAction();

        if (idSelectedAnimal >= 0)
            animalsMap[idSelectedAnimal].SetActive(false);

        animalsMap[idAnimal].SetActive(true);
        idSelectedAnimal = idAnimal;
    }
}
