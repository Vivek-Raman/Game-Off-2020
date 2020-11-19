using System;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool canInteract = false;
    public bool isInteracting = false;
    public NPC nearbyNPC = null;

    private Player player = null;

    private void Awake()
    {
        player = this.GetComponent<Player>();
    }

    private void Update()
    {
        if (!canInteract) return;
        if (!isInteracting && Input.GetKeyUp(KeyCode.E))
        {
            isInteracting = true;
            BeginInteraction();
        }
        if (isInteracting && Input.GetKeyUp(KeyCode.R))
        {
            isInteracting = false;
            EndInteraction();
        }
    }

    public void SetNearbyNPC(NPC nearby = null)
    {
        canInteract = (nearby != null);
        nearbyNPC = nearby;
    }

    private void BeginInteraction()
    {
        player.SetState(player.interactionState);
        Debug.Log("Interacting with " + nearbyNPC);
    }

    private void EndInteraction()
    {
        player.SetState(player.movementState);
        Debug.Log("Done with interaction");
    }
}
