using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NextTurnS : MonoBehaviour
{
    private List<EdTask> allEdTasks;

    void Update()
    {
        float nextTurnInput;
        nextTurnInput = Input.GetAxis("NextTurn");
        if (nextTurnInput > 0.2)
        {
            NextTurnFunc();
        }
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
            foreach (var i in allEdTasks)
            {
                i.SendResourcesChange();
            }
        }
    }

    public void GetEdTasks(List<EdTask> inputValue)
    {
        allEdTasks = inputValue;
    }

}
