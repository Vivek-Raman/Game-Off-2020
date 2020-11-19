using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private uint ID = 1;

    public override string ToString()
    {
        return "NPC " + ID.ToString();
    }
}