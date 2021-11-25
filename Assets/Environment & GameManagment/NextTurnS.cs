using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NextTurnS : MonoBehaviour
{
    private List<EdTask> allEdTasks;
    private bool playerSawResult = false;
    [SerializeField] private SetAciveResult setActiveResultEvent;

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!playerSawResult)NextTurnFunc();
            else GetCardBack();
        }
    }

    private void GetCardBack()
    {
        playerSawResult = false;
        setActiveResultEvent?.Invoke(false);
    }

    private void NextTurnFunc()
    {
        bool isDone = false;
        foreach (var i in allEdTasks)
        {
            if (i.GetComponentInChildren<Card>())
            {
                isDone = true;
                break;
            }
        }
        if (isDone)
        {
            setActiveResultEvent?.Invoke(true);
            foreach (var i in allEdTasks)
            {
                i.SendResourcesChange();
            }
            playerSawResult = true;
        }
    }

    public void GetEdTasks(List<EdTask> inputValue)
    {
        allEdTasks = inputValue;
    }

}

[System.Serializable]
public class SetAciveResult : UnityEvent<bool> { }