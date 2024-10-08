using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
// This class enables dragging functionality for UI elements in Unity.
public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Variable to store the original parent of the dragged object.
    Transform parentToReturnTo = null;
    // This method is called when the drag operation begins.
    public void OnBeginDrag(PointerEventData eventData)
    {
        // Store the current parent of the object to return to later.
        parentToReturnTo = this.transform.parent;
        // Move the object to the root of the hierarchy to avoid issues with layout groups.
        this.transform.SetParent(this.transform.parent.parent);
        // Log a message indicating the start of the drag.
        Debug.Log("Begin Drag");
        // Disable raycast blocking to allow interaction with other UI elements.
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    // This method is called during the drag operation.
    public void OnDrag(PointerEventData eventData)
    {
        // Update the position of the object to follow the mouse or touch position.
        this.transform.position = eventData.position;
        // Log a message indicating the drag is in progress.
        Debug.Log("Drag");
    }
    // This method is called when the drag operation ends.
    public void OnEndDrag(PointerEventData eventData)
    {
        // Return the object to its original parent.
        this.transform.SetParent(parentToReturnTo);
        // Log a message indicating the end of the drag.
        Debug.Log("End Drag");
        // Re-enable raycast blocking to restore normal interaction behavior.
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}