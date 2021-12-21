using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence4Pt2 : MonoBehaviour
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
                
                ("", "Wright Police Precinct"),
                ("Joseph","A lot has happened, I need to collect my thoughts."),
                ("_hideBG","" ),
                ("", "Joseph closes his eyes."),
                ("Joseph", "Let's start with each character."),
                ("_setFace", "smug"),
                ("Joseph", "Eliot."),
                ("Joseph", "He doesn't have a motive and he has a watertight alibi."),
                ("_setFace", "mad"),
                ("Joseph", "Jack."),
                ("Joseph", "He has a motive. Doesn't have a strong alibi, and he has a weapon."),
                ("Joseph", "But he said he didn't have the weapon, and his motive conflicts with the existence of the letter."),
                ("_setFace", "judgy"),
                ("Joseph", "Andreas..."),
                ("Joseph", "She doesn't have a motive. She is the most neutral one here."),
                ("Joseph", "But something is bothering me..."),
                ("Joseph", "Why does she have a hidden photo of Jack?"),
                ("Joseph", "Why does she have the same desk and same lamp as Jack?"),
                ("Joseph", "Wait..."),
                ("Andreas", "I don't think he should be fired."),
                ("Joseph", "No where else did they mention Jack would be fired."),
                ("Joseph", "Other than the letter..."),
                ("Andreas", "I don't know what she was writing..."),
                ("Joseph", "She is lying."),
                ("Joseph", "She is lying for Jack?"),
                ("Joseph", "For Jack?"),
                ("Joseph", "The desk, the lamp, the photo."),
                ("_hideCharacter",""),
                ("_showBG", ""),
                ("Joseph", "Oh...."),
                ("Joseph", "It's all coming together now."),
                ("Joseph", "It's Andreas."),
                ("_nextScene", "Sequence5")
            }


        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
