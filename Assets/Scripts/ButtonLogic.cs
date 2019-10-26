using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1()
    {
        print("Clicked button 1");
    }

    public void Button2()
    {
        print("Clicked button 2");
    }

    public void Button3()
    {
        print("Clicked button 3");
    }

    public void Button4()
    {
        print("Clicked button 4");
    }

    public void Button5()
    {
        print("Clicked button 5");
    }

    public void Button6()
    {
        print("Clicked button 6");
    }

    public void ButtonInventory()
    {
        print("Clicked button I");
        //GameObject canvasInventory = GameObject.Find("Canvas-Inventory");
        //Canvas canvas = canvasInventory.GetComponent<Canvas>();

        //isShowing = !isShowing;

        //canvas.enabled = isShowing;
    }

    public void ButtonQuests()
    {
        print("Clicked button Q");
    }
}
