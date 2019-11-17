using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroActions : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            bool isSlashingSword = !anim.GetBool("SlashingSword");

            if (isSlashingSword)
            {
                anim.SetBool("SlashingSword", true);
                Invoke("SwordSlash", 1.5f);
            }
        }
    }

    void SwordSlash()
    {
        anim.SetBool("SlashingSword", false);
    }
}
