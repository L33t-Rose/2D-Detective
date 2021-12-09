using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    public GameObject EVIDENCE_UI;
    public GameObject backGround;
    public GameObject character;
    public Animator anim;
    //We want a system that allows us to control the elements in our scene.
    //We can layout the order of events (A sequence) which allows us to perform any action listed.
    //Our TextBox should handle giving evidence. Since it's inline and we can set our rules inside of the 
    public static int currentTextBoxIndex = 0;
    public static (string speaker, string dialogue)[][] Sequence1;
    (int index, string state)[] face = new (int index, string state)[]
    {
        (5,"smug")
    };

    void obtainEvidence(string index)
    {
        var indexToInt = int.Parse(index);
        if(indexToInt >= 0)
        {
            var data = GameData.EVIDENCE_DATA[indexToInt];
            EVIDENCE_UI.SendMessage("loadEvidence", data);
            EVIDENCE_UI.SendMessage("show");
        }
    }

    void hideBackground()
    {
        backGround.transform.localScale = new Vector3(0, 0, 1);
    }

    void showBackground()
    {
        backGround.transform.localScale = new Vector3(13.31127f, 10.00116f, 1); ;
    }

    void hideCharacter()
    {
        character.transform.localScale = new Vector3(0, 0, 1);
    }
    void showCharacter()
    {
        character.transform.localScale = new Vector3(7, 7, 1);
    }

    void changeFace(string state)
    {
        anim.SetBool("smugPartner", false);
    }
}
