using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartNameSC : MonoBehaviour
{
    [SerializeField] Sprite[] spritesMale, spritesFemale;
    [SerializeField] Card[] cards;
    string[] maleNames = new string[7] { "����", "�������", "������", "�������", "�������", "����", "������" };
    string[] feMalenames = new string[5] { "���������", "�������", "�������", "�����", "�����" };

    void Awake()
    {
        foreach(Card i in cards)
        {
            if (Random.Range(1,3) == 2)
            {
                i.GetComponentsInChildren<Image>()[1].sprite = spritesFemale[Random.Range(0, spritesFemale.Length)];
                i.GetComponentInChildren<TextMeshProUGUI>().text = feMalenames[Random.Range(0, feMalenames.Length)];

            }
            else
            {
                i.GetComponentsInChildren<Image>()[1].sprite = spritesMale[Random.Range(0, spritesMale.Length)];
                i.GetComponentInChildren<TextMeshProUGUI>().text = maleNames[Random.Range(0, maleNames.Length)];

            }
        }
    }
}
