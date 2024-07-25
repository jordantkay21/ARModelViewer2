using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDebug : MonoBehaviour
{ 
    public void PrintOnSelection(GameObject button)
    {
        print(button.name + " was successfully selected");
    }
    public void PrintOnDeselection(GameObject button)
    {
        print(button.name + " was successfully unselected");
    }

    public void PrintCustomMessage(string message)
    {
        print(message);
    }
}

