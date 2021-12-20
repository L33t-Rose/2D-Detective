using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static int currentTextBoxIndex = 0;
    public static (string speaker, string dialogue)[][] Sequence;
    public static (int index, string state)[] faces;
    public static (string name, string desc)[] EVIDENCE_DATA;
    public static Sprite[] EVIDENCE_SPRITES;

    public static HashSet<(Sprite image, (string name, string desc))> OBTAINED_EVIDENCE = new HashSet<(Sprite, (string name, string desc))>();

    public static HashSet<GameObject> REQUIRED_INTERACTIONS;
    public static HashSet<GameObject> visited = new HashSet<GameObject>();

}
