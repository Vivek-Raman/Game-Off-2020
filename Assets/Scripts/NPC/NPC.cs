using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public uint ID = 1;
    public DialogueSet dialogue = null;

    public override string ToString()
    {
        return "NPC " + ID.ToString();
    }

}