using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EdTask : MonoBehaviour
{
    private EdTasksC task;
    [SerializeField] private EdTasksDistribution tasksArchive;
    // Start is called before the first frame update
    void Start()
    {
        task = tasksArchive.GetRandomEdTask();
        GetComponentInChildren<TextMeshProUGUI>().text = task.description;
    }

}
