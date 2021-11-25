using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributionSpecialTasks : MonoBehaviour
{
    [HideInInspector] public List<SpecialTasksClass> allTasks;

    void Awake()
    {
        int i = 0;
        allTasks = new List<SpecialTasksClass>();

        allTasks.Add(new SpecialTasksClass());
        allTasks[i].description = "\"Check\" the bank's security system";

        allTasks[i].moneyAdd = 100;
        allTasks[i].trustAdd = -10;
        allTasks[i].evilScoreAdd = 50;
        allTasks[i].levelCount = 3;
        int levelCount = allTasks[i].levelCount;

        allTasks[i].leveldescription = new string[levelCount];
        allTasks[i].levelChanceToLose = new int[levelCount];
        allTasks[i].levelChanceToLost = new int[levelCount];
        allTasks[i].levelOwnTrustAdd = new int[levelCount];
        int j = 0;

        allTasks[i].leveldescription[j] = "Take a picture of the camera location";
        allTasks[i].levelChanceToLose[j] = 10;
        allTasks[i].levelChanceToLost[j] = 0;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;


        i++;
        //
    }
}
