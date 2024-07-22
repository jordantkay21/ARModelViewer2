using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ExitButtonLogic : MonoBehaviour
{
  
    private XRInteractionManager interactionManager;
    private ARGestureInteractor gestureInteractor;

    private void Start()
    {
        interactionManager = FindAnyObjectByType<XRInteractionManager>();
        gestureInteractor = FindAnyObjectByType<ARGestureInteractor>();

        if (!interactionManager)
            print("Interaction Manager is Null");
        if (!gestureInteractor)
            print("Gesture Interactor is Null");
        
    }

    public void SelectCancel(ARSelectionInteractable selectionInteractable)
    {
        interactionManager.SelectExit(gestureInteractor, selectionInteractable);
        print("SelectCancel is called");
    }

    public void PrintMessage(string message)
    {
        print(message);
    }

    public void CheckIsSelected(ARSelectionInteractable selectionInteractable)
    {
        if (selectionInteractable.isSelected == true)
            print(selectionInteractable.name + " is currently selected");
        else
            print(selectionInteractable.name + " is currently not selected");
    }
}

