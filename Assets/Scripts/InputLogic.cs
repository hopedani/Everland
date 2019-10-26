using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputLogic : MonoBehaviour
{
    public EventSystem eventSystem;
    public List<Button> buttons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Pressed button 1");
            ClickButton(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("Pressed button 2");
            ClickButton(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("Pressed button 3");
            ClickButton(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("Pressed button 4");
            ClickButton(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            print("Pressed button 5");
            ClickButton(4);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Pressed button Q");
            ClickButton(5);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            print("Pressed button I");
            ClickButton(6);
        }
    }

    void ClickButton(int buttonIndex)
    {
        ExecuteEvents.Execute(buttons[buttonIndex].gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
    }
}
