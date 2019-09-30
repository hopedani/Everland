using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
    // used for state management of quests
     private enum QuestState
    {
        Uninitialized,
        Active,
        Complete
    }

    [SerializeField]
    private string questName;
    [SerializeField]
    private string questDescription;
    [SerializeField]
    private string npcDialogue;
    [SerializeField]
    private GameObject rewardItem;
    [SerializeField]
    private int goldReward;
    [SerializeField]
    private QuestState state;
    

}
