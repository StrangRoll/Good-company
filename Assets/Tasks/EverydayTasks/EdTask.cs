using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class EdTask : MonoBehaviour
{
    [SerializeField] CountResourcesEvent sendMoneyEvent, sendTrustEvent, sendEvilScoreEvent, sendPeopleEvent;
    private EdTasksC task;
    [SerializeField] private EdTasksDistribution tasksArchive;

    void Start()
    {
        GetRandomTask();
    }
    
    void GetRandomTask()
    {
        task = tasksArchive.GetRandomEdTask();
        GetComponentInChildren<TextMeshProUGUI>().text = task.description;
    }

    public void SendResourcesChange()
    {
        Card card = GetComponentInChildren<Card>();
        if (card != false)
        {
            if (Random.Range(0f,100f) <= task.chanceToLose)
            {
                sendTrustEvent?.Invoke(task.trustAdd * 2);
                if (Random.Range(0f, 100f) <= task.chanceToLost)
                {
                    sendTrustEvent?.Invoke(task.trustAdd * 2);
                    sendPeopleEvent?.Invoke(-1);
                    Destroy(card.gameObject);
                }
                else
                {
                    card.transform.SetParent(card.HandParent);
                    return;
                }
            }
            if (Random.Range(0f, 100f) <= task.chanceToRecruit)
            {
                sendPeopleEvent?.Invoke(1);
            }
            sendMoneyEvent?.Invoke(task.moneyAdd);
            sendTrustEvent?.Invoke(task.trustAdd);
            sendEvilScoreEvent?.Invoke(task.evilScoreAdd);
            card.transform.SetParent(card.HandParent);
        }
        GetRandomTask();
    }
}

[System.Serializable]
public class CountResourcesEvent : UnityEvent<int> { }
