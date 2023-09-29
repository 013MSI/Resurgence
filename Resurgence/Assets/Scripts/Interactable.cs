using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // add or remove an InteractionEvent component to this gameObject
    public bool useEvents;
    // message displayed to player when looking at an interactable
    public string promptMessage;

    // this fuction will be called from our player
    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }

    protected virtual void Interact() 
    {
        // we won't have any code written in this function
        // this is a template function to be overridden by our subclasses
    }
}
