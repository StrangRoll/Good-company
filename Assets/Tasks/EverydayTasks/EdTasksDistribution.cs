using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdTasksDistribution : MonoBehaviour
{
    [HideInInspector] public EdTasksC[] allTasks;
    // Start is called before the first frame update
    void Awake()
    {
        int i = 0;
        allTasks = new EdTasksC[10];

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "\"Fix\" A Neighbor's Car";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 10f;
        allTasks[i].chanceToLost = 0f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Organize A \"Charity\"";

        allTasks[i].moneyAdd = 25;
        allTasks[i].trustAdd = 15;
        allTasks[i].evilScoreAdd = 5;

        allTasks[i].chanceToLose = 0f;
        allTasks[i].chanceToLost = 0f;
        allTasks[i].chanceToRecruit = 15f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Buy \"Medicine\" For An Old Lady";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 15;

        allTasks[i].chanceToLose = 15f;
        allTasks[i].chanceToLost = 5f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Save People From \"Unnecessary\" Things";

        allTasks[i].moneyAdd = 20;
        allTasks[i].trustAdd = -15;
        allTasks[i].evilScoreAdd = 15;

        allTasks[i].chanceToLose = 25f;
        allTasks[i].chanceToLost = 15f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "\"Help\" The Police With The Investigation";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = 5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 20f;
        allTasks[i].chanceToLost = 10f;
        allTasks[i].chanceToRecruit = 5f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Selling Cookies \"Without Drugs\"";

        allTasks[i].moneyAdd = 35;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 0f;
        allTasks[i].chanceToLost = 25f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Offer To Invest Money In A \"Non-Pyramid Scheme\"";

        allTasks[i].moneyAdd = 25;
        allTasks[i].trustAdd = -10;
        allTasks[i].evilScoreAdd = 5;

        allTasks[i].chanceToLose = 15f;
        allTasks[i].chanceToLost = 0f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;


        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Give Children \"A Toy\" In The Form Of A Grenade";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -15;
        allTasks[i].evilScoreAdd = 30;

        allTasks[i].chanceToLose = 10f;
        allTasks[i].chanceToLost = 20f;
        allTasks[i].chanceToRecruit = 0f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Distribute \"Fresh\" Food To The Homeless";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 0f;
        allTasks[i].chanceToLost = 0f;
        allTasks[i].chanceToRecruit = 15f;
        allTasks[i].ownTrustAdd = 0f;
        i++;

        //

        allTasks[i] = new EdTasksC();
        allTasks[i].description = "Promise World Peace";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = 5;
        allTasks[i].evilScoreAdd = 0;

        allTasks[i].chanceToLose = 0f;
        allTasks[i].chanceToLost = 0f;
        allTasks[i].chanceToRecruit = 15f;
        allTasks[i].ownTrustAdd = 0f;
        i++;


    }

    public EdTasksC GetRandomEdTask()
    {
        return allTasks[Random.Range(0, allTasks.Length)];
    }
}
