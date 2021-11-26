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
        allTasks[i].levelCount = 6;
        int levelCount = allTasks[i].levelCount;

        allTasks[i].leveldescription = new string[levelCount];
        allTasks[i].levelChanceToLose = new int[levelCount];
        allTasks[i].levelChanceToLost = new int[levelCount];
        allTasks[i].levelOwnTrustAdd = new int[levelCount];
        int j = 0;

        allTasks[i].leveldescription[j] = "Take a picture of the camera location";
        allTasks[i].levelChanceToLose[j] = 15;
        allTasks[i].levelChanceToLost[j] = 0;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        // 

        allTasks[i].leveldescription[j] = "Buy \"Toy\" Weapons";
        allTasks[i].levelChanceToLose[j] = 30;
        allTasks[i].levelChanceToLost[j] = 15;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        // 

        allTasks[i].leveldescription[j] = "Prepare Cool Ñostume";
        allTasks[i].levelChanceToLose[j] = 0;
        allTasks[i].levelChanceToLost[j] = 0;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        // 

        allTasks[i].leveldescription[j] = "Arrange \"Fake\" Bank Robbery";
        allTasks[i].levelChanceToLose[j] = 60;
        allTasks[i].levelChanceToLost[j] = 80;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        // 

        allTasks[i].leveldescription[j] = "\" \"Kill\" \" The Actor Witnesses";
        allTasks[i].levelChanceToLose[j] = 25;
        allTasks[i].levelChanceToLost[j] = 100;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        //

        allTasks[i].leveldescription[j] = "Hide With \"Fake\" Money";
        allTasks[i].levelChanceToLose[j] = 30;
        allTasks[i].levelChanceToLost[j] = 30;
        allTasks[i].levelOwnTrustAdd[j] = 0;
        j++;

        i++;

        ////
    }

    public SpecialTasksClass GetRandomSpTask()
    {
        return allTasks[Random.Range(0, allTasks.Count)];
    }
}
