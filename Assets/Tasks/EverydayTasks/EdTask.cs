using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class EdTask : MonoBehaviour
{
    [SerializeField] CountResourcesEvent sendMoneyEvent, sendTrustEvent, sendEvilScoreEvent;

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
