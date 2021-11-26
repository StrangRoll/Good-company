using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpecialTaksSpawner : MonoBehaviour
{
    [SerializeField] private DistributionSpecialTasks archiveTasks;
    [SerializeField] private Transform photoTask, stepsTask;
    private int levelCount;
    private SpecialTasksClass task;
    private void Awake()
    {
        SpawnSpecialTask();
    }

    public void SpawnSpecialTask()
    {
        task = archiveTasks.GetRandomSpTask();
        levelCount = task.levelCount;
        photoTask.GetComponentInChildren<TextMeshProUGUI>().text = task.description;

        for (int i = 0; i < levelCount; i++)
        {
            if (i < levelCount)
            {
                stepsTask.GetChild(i).GetComponent<TextMeshProUGUI>().text = $"{i + 1}. {task.leveldescription[i]}";
            }
            else
            {
                stepsTask.GetChild(i).GetComponent<TextMeshProUGUI>().text = "";
            }
        }
    }
}
