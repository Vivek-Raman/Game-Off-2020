using System;
using UnityEngine;

public class PlayerProximityDetector : MonoBehaviour
{
    public GameObject bubble = null;

    private NPC npc = null;

    private void Awake()
    {
        npc = this.GetComponentInParent<NPC>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player in
            SetIcon(true);
            other.GetComponent<Interaction>().SetNearbyNPC(npc);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player out
            SetIcon(false);
            other.GetComponent<Interaction>().SetNearbyNPC(null);
        }
    }

    private void SetIcon(bool playerIsNear)
    {
        LeanTween.alpha(bubble, playerIsNear ? 1f : 0f, 0.4f).setEaseOutQuad();
        LeanTween.moveY(bubble, playerIsNear ? 2f : 1.25f, 0.5f).setEaseOutQuad();
    }
}