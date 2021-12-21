using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    //A Dialogue is an array of tupes. A Sequence is an array of Dialogues
    public static (string speaker, string dialogue)[][] Sequence;

    //Arrays for evidence data. Sprites are separate so we can set the list manually in the Unity Editor
    //The indexes for each should match
    public static (string name, string desc)[] EVIDENCE_DATA;
    public static Sprite[] EVIDENCE_SPRITES;

    //For Evidence UI. 
    public static HashSet<(Sprite image, (string name, string desc) details)> OBTAINED_EVIDENCE = new HashSet<(Sprite, (string name, string desc))>();

    //For allowing the player to go the next scene
    //REQUIRED_INTERACTIONS is a static list of all the actions the user can take
    //Made it a string for simplicity
    public static HashSet<string> REQUIRED_INTERACTIONS;
    public static HashSet<string> visited = new HashSet<string>();

    //For the final Sequence
    public static int FINAL_SCENE_INDEX = 0;
    public static string evidenceAboutToPresented = "";
    public static string[] correctAnswers = new string[]
    {
        "Orange Letter",
        "Photo",
        "Murder Weapon",
        "Log",
        "Murder Weapon"
    };
    public static (int correct, int incorrect)[] options = new(int correct, int incorrect)[] { 
        (2, 1), //First
        (4, 3), //Second
        (6, 5), //Third
        (8, 7), //Fourth
        (10,9)  //Fifth
    };

}
