using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueNode")]
public class DialogueNode : ScriptableObject
{
    [Header("Node")]
    public string NodeId;

    [Header("Dialogue")]
    public string SpeakerName;
    [TextArea(2,5)]
    public string DialogueText;

    [Header("Choices")]
    public List<DialogueChoice> Choices = new();
}

[System.Serializable]
public class DialogueChoice
{
    [Header("Text")]
    public string ChoiceText;

    [Header("Flow")]
    public string NextNodeId;
    public bool ReloadScene;

    [Header("Conditions")]
    public List<string> RequiredFlags = new();
    public List<string> ForbiddenFlags = new();

    [Header("FlagsOnSelect")]
    public List<string> GrantFlags = new();
}
