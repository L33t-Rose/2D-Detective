using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt2 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Pink Letter","A confession letter written by Eliot to Katie. Has *interesting* words, wouldn't recommend reading.")
        };

        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;

        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "So he sits next to her."),
                ("Joseph", "I can see why Jack calls him a simp.")
            },
            //1 Flower drawing
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A picture of a flower."),
                ("Joseph", "A flower with a familiar face."),
                ("Joseph", "Looks like they are missing 2 petals however."),
                ("Joseph", "Maybe I should have a picture of a flower at my desk."),
                ("", "That's a wonderful idea."),
                ("Joseph", "Who said that?"),
                ("_goTo","investigate")
            },
            //2 File in drawer
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A portfolio of files."),
                ("Joseph", "Seems like this is the files they were preparing for the meeting with the other company."),
                ("Joseph", "I shouldn't look into confidential informations."),
                ("_goTo","investigate")
            },
            //3 Pink letter
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "What are these pixels that are out of place?"),
                ("Thomas", "Detective, did you find something?"),
                ("Joseph", "Can you look into that pile of paper?"),
                ("Thomas", "I don't see anything, but sure."),
                ("", "Thomas searches through the paper."),
                ("Thomas", "!"),
                ("Thomas", "Detective Joseph, there's another letter."),
                ("Thomas", "I am still impressed how you can see these things."),
                ("Joseph", "Well, what is it?"),
                ("Thomas", "It's...a...letter...ew."),
                ("Joseph", "Let me see?"),
                ("Thomas", "NO! You don't have to read it. It's for your own good."),
                ("Thomas", "It's a letter written by Eliot to Katie."),
                ("Thomas", "A confession letter, with...*interesting* words."),
                ("Thomas", "...ewwwwww."),
                ("", "Thomas folds the letter in disgust."),
                ("Joseph", "Maybe I shouldn't read that letter."),
                ("_obtainEv", "0"),
                ("_hideObtainedEnv",""),
                ("_goTo","investigate")
                //obtained evidence 
            },
            //4 Laptop
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Eliot's laptop."),
                ("Joseph", "Looks like he is preparing for the presentation next week."),
                ("Joseph", "The show must go on aye?"),
                ("_goTo","investigate")
            },
            //5 post-it
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A to-do-list for Eliot."),
                ("Joseph", "Speak to Andreas about presentation."),
                ("Joseph", "Make copies for meeting."),
                ("Joseph", "Deliver letter on the 7th after work."),
                ("Joseph", "Sounds like typical office work."),
                ("_goTo","investigate")
            },

            //6 Proceed
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "So Eliot likes Katie and he planned to confess to her."),
                ("Joseph", "Wait..."),
                ("Joseph", "\"Deliver letter on the 7th after work.\""),
                ("Joseph", "He planned to give her the confession letter on the 7th after work..."),
                ("Thomas", "Then, he had to go find Katie after the meeting, which is around 7pm - 8pm!"),
                ("Joseph", "Looks like we got ourselves a sussy baka."),
                ("Thomas", "Please don't say that ever again."),
                ("_clearInteractions",""),
                ("_nextScene", "Sequence3Pt3")
            }




        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
