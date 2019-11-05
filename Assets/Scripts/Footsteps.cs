using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public float stepRate = 0.4f;
    public float stepCoolDown;
    public AudioClip footStep;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stepCoolDown -= Time.deltaTime;
        if ((Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f) && stepCoolDown < 0f)
        {
            GetComponent<AudioSource>().PlayOneShot(footStep, 0.9f);
            stepCoolDown = stepRate;
        }
    }
}
