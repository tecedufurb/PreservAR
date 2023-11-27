using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMenu : MonoBehaviour
{
    public InfoPanel infoPanel;
    public ActionController actionController;

    public List<GameObject> actions = new List<GameObject>();

    private int idAction = 0;

    public void NextAction(bool right)
    {
        actions[idAction].SetActive(false);

        if (right)
        {
            if (++idAction == actions.Count)
                idAction = 0;
        }
        else
        {
            if (--idAction == -1)
                idAction = actions.Count - 1;
        }

        infoPanel.ResetPanel();
        actionController.StopSound();

        actions[idAction].SetActive(true);
    }

    public void SelectAction()
    {
        actionController.ResetActualAction();

        switch (idAction)
        {
            case 0: infoPanel.ShowInfo(); break;
            case 1:
            case 2:
            case 3: actionController.idAction = idAction; break;
            case 4: actionController.PlaySound(); break;
        }
    }
}
