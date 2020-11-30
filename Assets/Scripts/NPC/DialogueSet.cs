using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCollection
{
    public string setTitle;
    public List<string> dialogue;


}

[CreateAssetMenu(menuName = "Create DialogueSet", fileName = "DialogueSet", order = 0)]
public class DialogueSet : ScriptableObject
{
    public uint npcID;
    public List<DialogueCollection> dialogues;

    public List<string> this[string lookup]
    {
        get => dialogues.[lookup].dialogue;
    }

}