using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence6 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;

    //This is where we 
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Autopsy Report","Name: Katie Miller\nCause Of Death:Knife wound to the chest, loss of blood.")
        };
        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;
        Debug.Log("list of evidence sprites" + EVIDENCE_SPRITES.Length);
        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        Debug.Log("required interaction list " + _requiredInteractions.Length);
        Debug.Log(GameData.REQUIRED_INTERACTIONS.Count);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {//Anim 0, empty,normal
             //     1, Eliot,smug
             //     2, Jack,mad 
             //     3, Andreas, judgy
                
                ("_hideCharacter",""),
                ("_hideBG",""),
                ("",""),
                ("",""),
                ("",""),
                ("","Interrogation Room"),
                ("_showBG",""),
                ("_showCharacter",""),
                ("Andreas", "I was in loved with Jack"),
                ("Andreas", "I loved every part of him."),
                ("Andreas", "I want to have every part of him to myself. His scent, his hair strands, his love."),
                ("Andreas", "I want to cherish all of him."),
                ("_setFace", "mad"),
                ("Andreas", "But that witch had to come in and ruin everthing."),
                ("Andreas", "She thinks my dear Jack doesn't work. But she is too puny to understand his beauty."),
                ("Andreas", "But such lowly ants dare to try to have my Jack fired."),
                ("_setFace", "judgy"),
                ("Andreas", "Seeing no choice, I have to silence her."),
                ("Andreas", "I took Jack's knife, followed Katie in the dark, and stabbed her."),
                ("_setFace","normal"),
                ("Andreas", "Unfortunately, I hurt my nails when I stabbed her."),
                ("Andreas", "I had to run away before she tried anything funny or have anyone see me."),
                ("_setFace","judgy"),
                ("Andreas", "So I left the knife in her chest while she was slowly dying."),
                ("_setFace","normal"),
                ("Andreas", "I thought wearing gloves wouldn't leave any fingerprints and there wouldn't be any fingerprints."),
                ("Andreas", "But my neglience has made my beloved Jack a suspect."),
                ("Andreas", "I had failed him."),
                ("Andreas", "I couldn't get rid of the letter, I had no chance of going back to the office and get the letter."),
                ("_setFace", "judgy"),
                ("Andreas", "But now that he is free, that is all I wanted."),
                ("_setFace", "normal"),
                ("Andreas", "That detective seems be good at his job."),
                ("_hideBG",""),
                ("Andreas", "It's almost as if he,"),
                ("_hideCharacter", ""),
                ("", "Could see things differently."),
                ("_nextScene", "Title")

            }


        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
