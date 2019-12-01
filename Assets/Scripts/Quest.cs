using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Quest
{
    // used for state management of quests
    public enum QuestState
    {
        Uninitialized,
        Active,
        Complete
    }

    // attributes for quests
    public string questName;
    [SerializeField]
    private string questDescription;
   
    [SerializeField]
    public GameObject npc;
    [SerializeField]
    public string npcDialogue;
    [SerializeField]
    public string npcName;
    [SerializeField]
    public Sprite npcPicture;
    [SerializeField]
    public GameObject rewardItem;
    [SerializeField]
    public int goldReward;
    [SerializeField]
    public QuestState state = QuestState.Uninitialized;

    [SerializeField]
    public List<GameObject> charactersList;

    [SerializeField]
    public List<Vector3> charactersPositions;

    public void StartQuest()
    {
        // check that the quest has enemies to defeat and instatiate them in the world
        if (charactersList.Count > 0)
        {
            for (int i = 0; i < charactersList.Count; i++)
            {
                GameObject.Instantiate(charactersList[i], charactersPositions[i], Quaternion.identity);
            }
            // will be used if characters can't be instantiated on the fly
            //for (int i = 0; i < charactersList.Count; i++)
            //    charactersList[i].SetActive(true);
        }
    }

    public void ShowDialogue() {

        // turn on panel to display npc dialogue window
        QuestManager.Instance.dialoguePanel.SetActive(true);
        // assign npc image
        QuestManager.Instance.dialoguePanel.transform.Find("NPCimage").GetComponent<Image>().sprite = npcPicture;
        // assign npc name
        QuestManager.Instance.dialoguePanel.transform.Find("NPCnameTxt").GetComponent<Text>().text = npcName;
        // assign npc dialogue
        QuestManager.Instance.dialoguePanel.transform.Find("NPCdialogueTxt").GetComponent<Text>().text = npcDialogue;    
    }

}
