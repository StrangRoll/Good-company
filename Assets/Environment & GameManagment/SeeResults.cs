using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeeResults : MonoBehaviour
{
    private int peopleCount = 0;

    public void CardToEachResult(Transform card, int[] resources)
    {
        SetResults(resources[0], resources[1], resources[2], resources[3]);
        Transform newPlace = transform.GetChild(peopleCount);
        newPlace.gameObject.SetActive(true);
        if (card) card.SetParent(newPlace.GetChild(0));
        peopleCount++;
    }

    public void SetActiveResult(bool active)
    {
        if (!active)
        {
            for (int i = 0; i < peopleCount; i++) 
            {
                Card card = GetComponentInChildren<Card>();
                if (card) GetItBack(card);
                transform.GetChild(i).gameObject.SetActive(false);
            }
            peopleCount = 0;
        }
        gameObject.SetActive(active);
    }

    public void SetResults(int people, int trust, int money, int evilScore)
    {
        Transform textPlacer = transform.GetChild(peopleCount).GetChild(1);

        textPlacer.GetChild(2).GetComponent<TextMeshProUGUI>().text = people.ToString();
        textPlacer.GetChild(3).GetComponent<TextMeshProUGUI>().text = trust.ToString();
        textPlacer.GetChild(6).GetComponent<TextMeshProUGUI>().text = money.ToString();
        textPlacer.GetChild(7).GetComponent<TextMeshProUGUI>().text = evilScore.ToString();

    }

    public void GetItBack(Card card)
    {
        card.transform.SetParent(card.HandParent);
    }
}
