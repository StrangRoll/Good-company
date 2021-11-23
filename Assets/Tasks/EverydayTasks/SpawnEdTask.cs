using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEdTask : MonoBehaviour
{
    [SerializeField] private int humanCount;
    [SerializeField] private Transform EdTaskExample, TasksParent;

    void Start()
    {
        for (int i = 1; i< humanCount; i++)
        {
            Transform newEdTask = Instantiate(EdTaskExample);
            newEdTask.SetParent(TasksParent, false);
        }
    }

}
