using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ResourcesControllerS : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI people, trust, money, evilScore;
    [SerializeField] UnityEvent addPeople;
    [SerializeField] private SendPeopleCount sendPeopleCountEvent;

    public void ChangePeople(int count)
    {
        int newCount;
        int.TryParse(people.text, out newCount);
        if (count > 0)
        {
            if (newCount < 8)
            {
                newCount += count;
                people.text = newCount.ToString();
                addPeople?.Invoke();
                sendPeopleCountEvent?.Invoke(newCount);
            }
        }
        else
        {
            if (newCount <= 1)
            {
                people.text = "Game Over";
            }
            else
            {
                newCount += count;
                people.text = newCount.ToString();
                sendPeopleCountEvent?.Invoke(newCount);
            }
        }
        
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



[System.Serializable]
public class SendPeopleCount : UnityEvent<int> { }