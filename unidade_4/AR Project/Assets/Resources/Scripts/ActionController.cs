using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    public AnimalMenu animalMenu;

    public List<Animator> animators = new List<Animator>();
    public List<Transform> target = new List<Transform>();
    public List<AudioSource> sources = new List<AudioSource>();

    public Transform animal;

    public GameObject banana;
    public GameObject grass;
    public GameObject steak;

    public int idAction = 0;

    private int actualTarget = 1;

    private void Start()
    {
        StopSound();
    }

    private void Update()
    {
        switch (idAction)
        {
            case 1: Drink(); break;
            case 2: Eat(); break;
            case 3: Walk(); break;
        }
    }

    public void ResetActualAction()
    {
        banana.SetActive(false);
        steak.SetActive(false);
        grass.SetActive(false);

        idAction = 0;
    }

    public void PlaySound()
    {
        sources[animalMenu.idSelectedAnimal].Play();
    }

    public void StopSound()
    {
        foreach (AudioSource source in sources)
            source.Stop();
    }

    private void Drink()
    {
        float posX = Vector3.MoveTowards(animal.position, target[0].position, 1).x;
        float posZ = Vector3.MoveTowards(animal.position, target[0].position, 1).z;

        animal.position = new Vector3(posX, animal.position.y, posZ);
        animal.LookAt(new Vector3(posX, animal.position.y, posZ), Vector3.back);

        if (animal.position.x == target[0].position.x && animal.position.z == target[0].position.z)
        {
            if (animalMenu.idSelectedAnimal == 0)
                animators[0].SetBool("Drink", true);
            else
                animators[animalMenu.idSelectedAnimal].SetBool("EatDrink", true);
        }

        StopAnimation();
    }

    private void Eat()
    {
        if (animalMenu.idSelectedAnimal == 0)
        {
            animators[0].SetBool("Eat", true);
            banana.SetActive(true);
        }
        else if (animalMenu.idSelectedAnimal == 1)
        {
            animators[1].SetBool("EatDrink", true);
            steak.SetActive(true);
        }
        else if (animalMenu.idSelectedAnimal == 2)
        {
            animators[2].SetBool("EatDrink", true);
        }
        else if (animalMenu.idSelectedAnimal == 3)
        {
            animators[3].SetBool("EatDrink", true);
            grass.SetActive(true);
        }

        StopAnimation();
    }

    private void Walk()
    {
        animators[animalMenu.idSelectedAnimal].SetBool("Walk", true);

        float posX = Vector3.MoveTowards(animal.position, target[actualTarget].position, 1).x;
        float posZ = Vector3.MoveTowards(animal.position, target[actualTarget].position, 1).z;

        animal.position = new Vector3(posX, animal.position.y, posZ);
        animal.LookAt(new Vector3(posX, animal.position.y, posZ), Vector3.back);

        if (animal.position.x == target[1].position.x && animal.position.z == target[1].position.z)
            actualTarget = 2;
        else if (animal.position.x == target[2].position.x && animal.position.z == target[2].position.z)
            actualTarget = 3;
        else if (animal.position.x == target[3].position.x && animal.position.z == target[3].position.z)
            actualTarget = 1;
    }

    private IEnumerator StopAnimation()
    {
        if (idAction != 1)
            animators[animalMenu.idSelectedAnimal].SetBool("Walk", false);

        yield return new WaitForSeconds(2f);

        if (animalMenu.idSelectedAnimal != 0)
        {
            animators[animalMenu.idSelectedAnimal].SetBool("EatDrink", false);
        }
        else
        {
            animators[animalMenu.idSelectedAnimal].SetBool("Eat", false);
            animators[animalMenu.idSelectedAnimal].SetBool("Drink", false);
        }

        animators[animalMenu.idSelectedAnimal].SetBool("Walk", false);

        ResetActualAction();
    }
}
