using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence2 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;
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

        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;

        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
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
                ("_setFace", "mad"),
                ("Jack", "Look man, I didn’t kill Katie."),
                ("Jack", "I’ve been trying to tell you guys I didn’t do it."),
                ("Jack", "You guys come and go, asking me questions. But I will only say one thing."),
                ("Jack", "I"),
                ("Jack", "DIDN'T"),
                ("Jack", "KILL"),
                ("Jack", "KATIE")
            },
            //1
            new (string speaker, string dialogue)[] //dialogue choice for "Alibi?"
            { 
                ("Joseph", "Where were you at the night of-"),
                ("Jack", "I am not saying anything. You won’t believe me anyway."),
                ("Jack", "All of you look at me like I am the murderer."),
                ("Jack", "That's why you still arrested me!"),
                ("Joseph", "Look, if you say you didn’t do it, I need evidence to prove that you didn’t do it."),
                ("Joseph", "You have to tell us things, something to work with."),
                ("Joseph", "If not, I can’t help you and you’ll have to like the jail cell they will put you in. "),
                ("Jack", "..."),
                ("Joseph", "I will ask you again. Where were you on the night of the 7th?"),
                ("_setFace", "normal"),
                ("Jack", "I was at the office. Working with the others until 7pm."),
                ("Joseph", "What were you working on?"),
                ("Jack", "A presentation for a meeting next week."),
                ("Joseph", "When did you leave the office?"),
                ("Jack", "After our meeting ended. I don’t remember what time exactly."),
                ("Joseph", "What did you do after?"),
                ("Jack", "I went to buy food and I went home."),
                ("Joseph", "Do you have the receipts?"),
                ("Jack", "No, I wasn’t planning to return the chicken teriyaki.")
            },
            //2
            new (string speaker, string dialogue)[]//dialogue for "What Happeened?"
            { 
                ("Joseph", "Do you remember what happened during that meeting?"),
                ("Jack", "We were just spending that night making powerpoints."),
                ("Joseph", "Anything special happened?"),
                ("Jack", "No, I don't remember anything weird happening."),
                ("Joseph", "(God, you have to give me something to with.)"),
                ("Jack", "I don't know what you are expecting."),
                ("Jack", "There weren't any office drama."),
                ("Jack", "No one hated each other."),
                ("Jack", "But there was office romance."),
                ("Joseph", "Would you like to tell me more about it?"),
                ("Jack", "I knew Eliot liked Katie."),
                ("Jack", "Although Eliot was working on the presentation with Andreas, he kept eyeing Katie."),
                ("Jack", "Maybe because Katie was writing a letter instead of helping."),
                ("Joseph", "A letter?"),
                ("Jack", "A letter. I don't know what she was writing, but she was writing a lot.")
            },
            //3
            new (string speaker, string dialogue)[] //dialogue for "Relation with coworkers"
            { 
                ("Joseph", "How would you describe your coworkers?"),
                ("Jack", "I don't particularly like them, and I know why you guys arrested me."),
                ("Jack", "Katie and I have been enemies, she thinks I am slacking and I am not doing work."),
                ("Jack", "I hate those people who thinks you don't do anything when they can't see it."),
                ("Jack", "You guys probably think 'He has history with Katie' so I have motive."),
                ("Jack", "But you guys have no concrete evidence that it was me."),
                ("Joseph", "(He doesn't think we have concrete evidence...)"),
                ("Joseph", "(Is he stupid?)"),
                ("Joseph", "Alright, what about others?"),
                ("Joseph", "What do you think about Eliot?"),
                ("Jack", "Eliot?"),
                ("_setFace", "judgy"),
                ("Jack", "Biggest simp I've seen."),
                ("Jack", "He always has some brown on his nose. ")



            }

        };


        print("Initialized");
    }
    
    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
