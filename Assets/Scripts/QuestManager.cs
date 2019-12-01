using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // make this class a singleton... there can be only one!
    private static QuestManager instance;
    public static QuestManager Instance { get { return instance; } }

    private void Awake()
    {
        // ensure that only one quest manager script exists in game
        if (!instance)
            instance = this;
        else
            Destroy(this);

        // used to ensure that the quest manager isn't destroyed when scenes are loaded/unloaded
        DontDestroyOnLoad(this.gameObject);

        // if no quest is active (first time playing) then activate first quest
        for (int i = 0; i < quests.Count; i++)
            if (quests[i].state == Quest.QuestState.Active)
                currentQuest = i;
            else
            {
                currentQuest = 0;
                quests[currentQuest].state = Quest.QuestState.Active;
                
            }
        // create first npc marker (exclamtion point)
        GameObject.Instantiate(exclamtionPoint, new Vector3(quests[currentQuest].npc.transform.position.x - 0.85f, quests[currentQuest].npc.transform.position.y + 3.208f, quests[currentQuest].npc.transform.position.z - 0.06f), Quaternion.identity);
    }

    // used for easy addition/subtraction of quests in the inspector
    public List<Quest> quests = new List<Quest>();

    public GameObject dialoguePanel;
    public GameObject hero;
    public GameObject gameOverPanel;
    public GameObject exclamtionPoint;
    public int currentQuest;
    bool questCompleted = false;
    bool questHasStarted = false;

    private void Update()
    {

        //check for all enemies destroyed (signals the completion of a quest)
        if (quests[currentQuest].charactersList.Count == 0 && questCompleted == false)
            QuestComplete();
    }

    public void StartQuest()
    {
        if (!questHasStarted)
        {
            // check to see what quest is currently active
            for (int i = 0; i < quests.Count; i++)
                if (quests[i].state == Quest.QuestState.Active)
                {
                    currentQuest = i;
                    questCompleted = false;
                }
            //check for and instatiate enemies
            if (quests[currentQuest].charactersList.Count > 0)
            {
                for (int i = 0; i < quests[currentQuest].charactersList.Count; i++)
                {
                    GameObject.Instantiate(quests[currentQuest].charactersList[i], quests[currentQuest].charactersPositions[i], Quaternion.identity);
                }
                // will be used if characters can't be instantiated on the fly
                //for (int i = 0; i < charactersList.Count; i++)
                //    charactersList[i].SetActive(true);
                questHasStarted = true;
            }
        }
    }

    public void QuestComplete()
    {
        // check if next quest exists, if so set it to active state, if not pop up the game over panel
        if (currentQuest < (quests.Count - 1))
        {
            GameObject.Instantiate(quests[currentQuest].rewardItem, new Vector3(hero.transform.position.x, hero.transform.position.y + 1, hero.transform.position.z + 2), Quaternion.identity);
            quests[currentQuest].state = Quest.QuestState.Complete;
            questCompleted = true;
            Destroy(GameObject.Find("exclamationPoint(Clone)"));
            quests[currentQuest + 1].state = Quest.QuestState.Active;
            currentQuest += 1;
            GameObject.Instantiate(exclamtionPoint, new Vector3(quests[currentQuest].npc.transform.position.x - 0.85f, quests[currentQuest].npc.transform.position.y + 3.208f, quests[currentQuest].npc.transform.position.z - 0.06f), Quaternion.identity);
            questHasStarted = false;

        }
        else if (currentQuest == quests.Count - 1)
        {
            quests[currentQuest].state = Quest.QuestState.Complete;
            // activate game over panel
            gameOverPanel.SetActive(true);
        }       
        
    }

}
