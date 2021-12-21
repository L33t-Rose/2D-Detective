using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence4Pt1 : MonoBehaviour
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
            {
                ("_hideBG", ""),
                ("_hideCharacter",""),
                ("","B' Piano inc."),
                ("_showBG",""),
                ("Joseph", "Are you sure this is the place?"),
                ("Thomas", "She said she has a concert coming up so she took a few days off at work."),
                ("Joseph", "Concert?"),
                ("Thomas", "Andreas Grace is a pianist."),
                ("Thomas", "Although she isn't exactly famous, she is slowly building a reputation."),
                ("Joseph", "I see."),
                ("_showCharacter",""),
                ("", "Andreas went through the glass door."),
                ("Joseph", "Hi, are you Andreas Grace?"),
                ("", "Joseph reaches out his hand"),
                ("Andreas", "Yes, and you are?"),
                ("Joseph", "I am detective Joseph Wilson from Wright Police Deparment."),
                ("Andreas", "Oh, nice to meet you detective."),
                ("", "Andreas shakes Joseph's hand."),
                ("Andreas", "Ouch."),
                ("Joseph", "Oh, I am sorry."),
                ("Joseph", "(I don't think I shook her right hand that hard. Is it injured?"),
                ("Andreas", "It's fine. What can I help you with, detective?"),
                ("Joseph", "We just have a few simple questions for you. I will remind you that anything you say will be admissable in court."),
                ("Andreas", "Sure thing, can you make it quick? I have piano rehearsal for my concert two days from now.")
            },
            //1 What Happened?
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Where were you on the night of the 7th?"),
                ("Andreas", "I was in a meeting with Jack, Eliot, and Katie. We were preparing for the presentation for a meeting with another company."),
                ("Andreas", "Well, I was preparing it and Eliot was helping. Jack was playing with his black box and Katie was writing a letter."),
                ("Joseph", "Do you know what was inside the black box?"),
                ("Andreas", "Yep, Jack said his friend gave him the knife he longed for."),
                ("Joseph", "And Katie was writing a letter?"),
                ("Andreas", "She was flipping through her files and she was writing multiple pages."),
                ("Andreas", "I don't know what she was writing, but it was weird how she wanted to do that instead of helping.")
            },
            //2 Alibi
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "When did you leave the office?"),
                ("Andreas", "After the meeting ended. Aroung 7 pm, I don't remember when exactly."),
                ("Andreas", "I wanted to go home because I was tired."),
                ("Joseph", "What did you do after leaving the office?"),
                ("Andreas", "My roomate was nearby, so she drove me home. If you want proof, there's a time stamp of a call on my phone when she came to pick me up."),
                ("Joseph", "Do you mind letting me see the time stamp?"),
                ("Andreas", "Sure."),
                ("", "Andreas shows Joseph her phone."),
                ("", "\"Incoming call from Kiara. Lasted 2 minutes. September 7th, 7:40\""),
                ("Joseph", "Thank you.")
            },
            //3 Relations
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "How would you describe your relationships with your coworkers?"),
                ("Andreas", "Eliot is a kind man. He pays attention to his work and he is reliable when the time comes."),
                ("Andreas", "Although Katie is reliable, she thinks too highly of herself."),
                ("Andreas", "She thinks Jack doesn't do anything but she doesn't do anything herself sometimes."),
                ("Andreas", "Jack is in the middle of doing something and not doing something."),
                ("Andreas", "He does things that we can't see, but his performance isn't up to par."),
                ("Andreas", "With that being said, I don't think he should be fired."),
                ("Joseph", "(\"I don't think he should be fired.\")"),
                ("Joseph", "(Hmm)")
            },
            //4 Proceed
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Thank you for cooperating, that will be all."),
                ("Andreas", "No problem, I will go back to preparing for my concert then."),
                ("Andreas", "And detective."),
                ("Joseph", "Yes?"),
                ("Andreas", "Thank you for your service and please catch the killer."),
                ("Andreas", "I heard Jack was arrested. Although he is Katie's enemy, I don't know he would kill her."),
                ("Joseph", "I will do my best to find the truth."),
                ("", "Andreas went back to the building."),
                ("Joseph", "We should head back to the precinct."),
                ("Thomas", "Detective?"),
                ("Joseph", "I think I have everything I need. I just need to think."),
                ("_nextScene","Sequence4Pt2")

            }


        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
