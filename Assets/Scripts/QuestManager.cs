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
    }

    // used for easy addition/subtraction of quests in the inspector
    public List<Quest> quests;

    // used for state management of quests
    private enum QuestState
    {
        Uninitialized,
        Active, 
        Complete
    }
}
