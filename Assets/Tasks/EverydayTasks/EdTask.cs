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
    [SerializeField] private SendCard sendCardEvent;
    private Card card;


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
        card = GetComponentInChildren<Card>();
        if (card != false)
        {

            if (Random.Range(0f,100f) <= task.chanceToLose)
            {
                sendTrustEvent?.Invoke(task.trustAdd * 2);
                if (Random.Range(0f, 100f) <= task.chanceToLost)
                {
                    sendTrustEvent?.Invoke(task.trustAdd * 2);
                    sendPeopleEvent?.Invoke(-1);
                    sendCardEvent?.Invoke(card.transform, task.description, new int[4] { -1, task.trustAdd * 4, 0, 0 }); 
                    Destroy(card.gameObject);
                    return;
                }
                else
                {
                    sendCardEvent?.Invoke(card.transform, task.description, new int[4] { 0, task.trustAdd * 2, 0, 0 });
                    return;
                }
            }
            if (Random.Range(0f, 100f) <= task.chanceToRecruit)
            {
                sendPeopleEvent?.Invoke(1);
                sendCardEvent?.Invoke(card.transform, task.description, new int[4] { 1, task.trustAdd, task.moneyAdd, task.evilScoreAdd });
            }
            else
            {
                sendCardEvent?.Invoke(card.transform, task.description, new int[4] { 0, task.trustAdd, task.moneyAdd, task.evilScoreAdd });
            }
            sendMoneyEvent?.Invoke(task.moneyAdd);
            sendTrustEvent?.Invoke(task.trustAdd);
            sendEvilScoreEvent?.Invoke(task.evilScoreAdd);
        }
        GetRandomTask();
    }
}

[System.Serializable]
public class CountResourcesEvent : UnityEvent<int> { }

[System.Serializable]
public class SendCard : UnityEvent<Transform, string, int[]> { }
