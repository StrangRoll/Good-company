using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeeResults : MonoBehaviour
{
    private int peopleCount = 0;

    public void CardToEachResult(Transform card, string description, int[] resources)
    {
        SetResults(resources[0], resources[1], resources[2], resources[3], description);
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
    
    private void SetResults(int people, int trust, int money, int evilScore, string description)
    {
        Transform textResourcesPlacer = transform.GetChild(peopleCount).GetChild(1);

        textResourcesPlacer.GetChild(2).GetComponent<TextMeshProUGUI>().text = people.ToString();
        textResourcesPlacer.GetChild(3).GetComponent<TextMeshProUGUI>().text = trust.ToString();
        textResourcesPlacer.GetChild(6).GetComponent<TextMeshProUGUI>().text = money.ToString();
        textResourcesPlacer.GetChild(7).GetComponent<TextMeshProUGUI>().text = evilScore.ToString();
        
        //

        Transform textDescritionPlacer = transform.GetChild(peopleCount).GetChild(2);

        textDescritionPlacer.GetComponent<TextMeshProUGUI>().text = description;
    }

    public void GetItBack(Card card)
    {
        card.transform.SetParent(card.HandParent);
    }
}
