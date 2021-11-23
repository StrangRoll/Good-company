using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourcesControllerS : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI people, trust, money, evilScore;

    public void ChangePeople(int count)
    {
        int newCount;
        int.TryParse(people.text, out newCount);
        newCount += count;
        people.text = newCount.ToString();
    }

    public void ChangeTrust(int count)
    {
        int newCount;
        int.TryParse(trust.text, out newCount);
        newCount += count;
        trust.text = newCount.ToString();
    }

    public void ChangeMoney(int count)
    {
        int newCount;
        int.TryParse(money.text, out newCount);
        newCount += count;
        money.text = newCount.ToString();
    }

    public void ChangeEvilScore(int count)
    {
        int newCount;
        int.TryParse(evilScore.text, out newCount);
        newCount += count;
        evilScore.text = newCount.ToString();
    }

}



