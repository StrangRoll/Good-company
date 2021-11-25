using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdTasksDistribution : MonoBehaviour
{
    [HideInInspector] public List<EdTasksC> allTasks;
    // Start is called before the first frame update
    void Awake()
    {
        int i = 0;
        allTasks = new List<EdTasksC>();

        allTasks.Add(new EdTasksC());
        allTasks[i].description = "\"Fix\" A Neighbor's Car";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 10;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Organize A \"Charity\"";

        allTasks[i].moneyAdd = 25;
        allTasks[i].trustAdd = 15;
        allTasks[i].evilScoreAdd = 5;

        allTasks[i].chanceToLose = 0;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 15;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Buy \"Medicine\" For An Old Lady";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 15;

        allTasks[i].chanceToLose = 15;
        allTasks[i].chanceToLost = 5;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Save People From \"Unnecessary\" Things";

        allTasks[i].moneyAdd = 20;
        allTasks[i].trustAdd = -15;
        allTasks[i].evilScoreAdd = 15;

        allTasks[i].chanceToLose = 25;
        allTasks[i].chanceToLost = 15;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Tweet About People's Rights";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = 10;
        allTasks[i].evilScoreAdd = -5;

        allTasks[i].chanceToLose = 0;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Selling Cookies \"Without Drugs\"";

        allTasks[i].moneyAdd = 35;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 25;
        allTasks[i].chanceToLost = 75;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 25;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Offer To Invest Money In A \"Non-Pyramid Scheme\"";

        allTasks[i].moneyAdd = 25;
        allTasks[i].trustAdd = -10;
        allTasks[i].evilScoreAdd = 5;

        allTasks[i].chanceToLose = 15;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;


        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Give Children \"A Toy\" In The Form Of A Grenade";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -15;
        allTasks[i].evilScoreAdd = 30;

        allTasks[i].chanceToLose = 10;
        allTasks[i].chanceToLost = 20;
        allTasks[i].chanceToRecruit = 0;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Distribute \"Fresh\" Food To The Homeless";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = -5;
        allTasks[i].evilScoreAdd = 10;

        allTasks[i].chanceToLose = 0;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 15;
        allTasks[i].ownTrustAdd = 0;
        i++;

        //
        allTasks.Add(new EdTasksC());
        allTasks[i].description = "Promise World Peace";

        allTasks[i].moneyAdd = 0;
        allTasks[i].trustAdd = 5;
        allTasks[i].evilScoreAdd = 0;

        allTasks[i].chanceToLose = 0;
        allTasks[i].chanceToLost = 0;
        allTasks[i].chanceToRecruit = 15;
        allTasks[i].ownTrustAdd = 0;
        i++;


    }

    public EdTasksC GetRandomEdTask()
    {
        return allTasks[Random.Range(0, allTasks.Count)];
    }
}
