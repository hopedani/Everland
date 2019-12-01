using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogueOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerStay(Collider col)
    {
        if (col.name.Equals("paladin_prop_j_nordstrom") && Input.GetKeyDown(KeyCode.Q))
            if(this.gameObject.name == QuestManager.Instance.quests[QuestManager.Instance.currentQuest].npc.name)
                QuestManager.Instance.quests[QuestManager.Instance.currentQuest].ShowDialogue();
    }
}
