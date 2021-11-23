using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartNameSC : MonoBehaviour
{
    [SerializeField] Sprite[] spritesMale, spritesFemale;
    [SerializeField] Transform cardExample;
    [SerializeField] private Transform peopleParent;
    [SerializeField] int peopleCount;

    string[] maleNames = new string[7] { "Max", "Bernard", "Frank", "Conor", "Richard", "Jacob", "Clark" };
    string[] feMalenames = new string[7] { "Divya", "Jeanne", "Lia", "Julie", "Camilla", "Natalie", "Lydia" };

    void Awake()
    {
        for(int i = 0;i< peopleCount; i++) 
        {
            AddNewPeople();
        }
    }

    public void AddNewPeople()
    {
        Transform newPeople = Instantiate(cardExample);
        newPeople.SetParent(peopleParent, false);

        if (Random.Range(1, 3) == 2)
        {
            newPeople.GetComponentsInChildren<Image>()[1].sprite = spritesFemale[Random.Range(0, spritesFemale.Length)];
            newPeople.GetComponentInChildren<TextMeshProUGUI>().text = feMalenames[Random.Range(0, feMalenames.Length)];

        }
        else
        {
            newPeople.GetComponentsInChildren<Image>()[1].sprite = spritesMale[Random.Range(0, spritesMale.Length)];
            newPeople.GetComponentInChildren<TextMeshProUGUI>().text = maleNames[Random.Range(0, maleNames.Length)];

        }
    }
}



