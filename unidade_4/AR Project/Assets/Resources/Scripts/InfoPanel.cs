using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    public AnimalMenu animalMenu;

    public GameObject panel;

    public TextMeshPro animalName;
    public TextMeshPro animalContent;

    private int idInfo = 0;

    public void ShowInfo()
    {
        panel.SetActive(true);

        switch (animalMenu.idSelectedAnimal)
        {
            case 0:
                {
                    animalName.text = "Bugio-Ruivo";

                    if (idInfo == 0)
                    {
                        animalContent.text = "NOME CIENTÍFICO:\n" +
                            "Alouatta Guariba Clamitans\n\n" +
                            "ONDE É ENCONTRADO:\n" +
                            "Região leste do Brasil, ao longo da Mata Atlântica";
                        idInfo = 1;
                    }
                    else
                    {
                        animalContent.text = " Machos 55cm / Fêmeas 49,5cm\n\n" +
                            "PESO: Machos 7,7kg / Fêmeas 5kg\n\n" +
                            "HABITAT: Regiões mais altas da cobertura florestal";
                        idInfo = 0;
                    }
                }
            break;

            case 1:
                {
                    animalName.text = "Onça Pintada";

                    if (idInfo == 0)
                    {
                        animalContent.text = "NOME CIENTÍFICO:\n" +
                            "Panthera Onca\n\n" +
                            "ONDE É ENCONTRADO:\n" +
                            "Brasil, em florestas como a Amazônica e a Mata Atlântica, em ambientes abertos como Pantanal e o Cerrado";
                        idInfo = 1;
                    }
                    else
                    {
                        animalContent.text = "TAMANHO: 1 - 2 mestros\n\n" +
                            "PESO: 135kg\n\n" +
                            "HABITAT: Florestas densas";
                        idInfo = 0;
                    }
                }
            break;

            case 2:
                {
                    animalName.text = "Arara azul";

                    if (idInfo == 0)
                    {
                        animalContent.text = "NOME CIENTÍFICO:\n" +
                            "Anodorhynchus Hyacinthinus\n\n" +
                            "ONDE É ENCONTRADO:\n" +
                            "Regiões tropicais, em especial Brasil, Paraguai e Bolívia";
                        idInfo = 1;
                    }
                    else
                    {
                        animalContent.text = "TAMANHO: 75cm\n\n" +
                            "PESO: 950g\n\n" +
                            "HABITAT: Diversos biomas, principalmente no Pantanal e nas bordas das cordilheiras";
                        idInfo = 0;
                    }
                }
                break;

            case 3:
                {
                    animalName.text = "Anta";

                    if (idInfo == 0)
                    {
                        animalContent.text = "NOME CIENTÍFICO:\n" +
                            "Tapirus Terrestres\n\n" +
                            "ONDE É ENCONTRADO:\n" +
                            "Mata Atlântica existem populações viáveis concentradas na Serra do mar, nos estados de SP e PR";
                        idInfo = 1;
                    }
                    else
                    {
                        animalContent.text = "TAMANHO: 2m\n\n" +
                            "PESO: 180 - 300 quilos\n\n" +
                            "HABITAT: Florestas tropicais de planícies e montanhosas, matas ciliares, pântanos, veredas, lagos e córregos";
                        idInfo = 0;
                    }
                }
            break;
        }
    }

    public void ResetPanel()
    {
        panel.SetActive(false);
        idInfo = 0;
    }
}
