using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnEdTask : MonoBehaviour
{
    [SerializeField] private int humanCount;
    [SerializeField] private Transform EdTaskExample, TasksParent;
    private List<EdTask> AllEdTasks;
    [SerializeField] SendAkTasksEvent edTasksEvent;
    void Start()
    {
        SpawnTasks();
    }

    void SpawnTasks()
    {
        AllEdTasks = new List<EdTask>() { EdTaskExample.GetComponent<EdTask>() };
        for (int i = 1; i< humanCount + 2; i++)
        {
            Transform newEdTask = Instantiate(EdTaskExample);
            newEdTask.SetParent(TasksParent, false);
            AllEdTasks.Add(newEdTask.GetComponent<EdTask>());
        }
        edTasksEvent?.Invoke(AllEdTasks);
    }

}
[System.Serializable]
public class SendAkTasksEvent : UnityEvent<List<EdTask>> { }