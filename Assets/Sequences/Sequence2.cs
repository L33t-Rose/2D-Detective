using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence2 : MonoBehaviour
{
    public static Sprite[] EVIDENCE_SPRITES;
    public (string name, string desc)[] EVIDENCE_DATA;
    public static (string speaker, string dialogue)[][] Sequence;
    (int index, string state)[] face = new (int index, string state)[]
    {
        (5,"smug")
    };
    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Autopsy Report","Name: Katie Miller\nCause Of Death:Knife wound to the chest, loss of blood.")
        };
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            new (string speaker, string dialogue)[]
            {
                ("_hideCharacter",""),
                ("_hideBG",""),
                ("", "Interrogation room"),
                ("_showBG", ""),
                ("Officer", "I will bring him to the room detective, he is just outside."),
                ("Joseph", "Thank you."),
                ("Thomas", "Detective."),
                ("Joseph", "Yes?"),
                ("Thomas", "I think we should be a bit careful, I heard our suspect had some issues when he was arrested."),
                ("Joseph", "(Well, either he was afraid of getting caught or he was mad because he is innocent)"),
                ("Joseph", "I will keep that in mind."),
                ("Officer", "Jack Willow, please take a seat."),
                ("Joseph", "(Here he comes.)"),
                ("_showCharacter",""),
                ("Jack", "..."),
                ("Joseph", "Hi, I am detective Wilson. Are you Jack Willow?"),
                ("Jack", "..Yes." ),
                ("Joseph", "Before we begin, I will remind you that anything you say is-"),
                ("Jack", "Look man, I didn’t kill Katie."),
                ("Jack", "I’ve been trying to tell you guys I didn’t do it."),
                ("Jack", "You guys come and go, asking me questions. But I will only say one thing."),
                ("Jack", "I"),
                ("Jack", "DIDN'T"),
                ("Jack", "KILL"),
                ("Jack", "KATIE")
            },
            new (string speaker, string dialogue)[] //dialogue choice for "Alibi?"
            { 
                ("Joseph", "Where were you at the night of-"),
                ("Jack", "I am not saying anything. You won’t believe me anyway."),
                ("Jack", "All of you look at me like I am the murderer."),
                ("Jack", "That's why you still arrested me!"),
                ("Joseph", "Look, if you say you didn’t do it, I need evidence to prove that you didn’t do it.")
            }
        };

        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
