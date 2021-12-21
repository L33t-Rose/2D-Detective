using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt1 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Orange Letter","A letter written by Katie. Contains Jack's misdeamnors and request of Jack's removal from the office.")
        };

        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;

        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {
                ("_hideBG",""),
                ("_hideCharacter",""),
                ("","Jim & Leo Inc."),
                ("_showBG",""),
                ("Joseph", "Why do I feel like they have a better working environment than our princt?"),
                ("Thomas", "Don't say that out loud man."),
                ("Joseph", "Hey, I think that's one of the suspects."),
                ("","Joseph walks up to the man."),
                ("_showCharacter",""),
                ("Joseph", "Detective Wilson from Wright Police Department, are you Eliot Bernandez?"),
                ("", "Joseph shows him his badge."),
                ("Eliot", "T-That's me, sir."),
                ("Joseph", "How are you today?"),
                ("", "Joseph reaches out his hand."),
                ("Eliot", "I-I am doing fine sir."),
                ("", "Eliot shakes Joseph's hand."),
                ("Joseph", "We are here to investigate the case of Katie Miller. Do you mind showing us around and answering a few questions?"),
                ("Eliot", "S-Sure thing, Katie's desk is actually right here. We were told not to touch it."),
                ("Eliot", "Mine is to her left."),
                ("Eliot", "Jack and Andreas are on the other side. Next to the wall."),
                ("Joseph", "Thank you, we will investigate them and we will ask you a few questions."),
                ("Eliot", "Uh, absolutely officer."),
                ("_setFace","nothing"),
                ("", "Eliot leaves."),
                ("Joseph", "I suppose we should take a look at these desks.")
            },
                //1 Printer
               new (string speaker, string dialogue)[]
               {
                   ("Joseph", "Hm, She has her own printer."),
                   ("Joseph", "On top of boxes of files? Doesn't seem stable to me."),
                   ("_goTo","investigate")
               },
               //2 letter
               new (string speaker, string dialogue)[]
               {
                   ("Joseph", "Hmm, what is this sticking out of the folders?"),
                   ("Thomas", "Looks like a envelope."),
                   ("", "Thomas reaches it and opens it up."),
                   ("Thomas", "Uh...detective?"),
                   ("Joseph", "What is it Thomas?"),
                   ("Thomas", "This was a letter written by Katie. To the manager at Jim & Leo Inc."),
                   ("Thomas", "The letter has a list of Jack's terrible behavior and misconducts. Katie wants Jack to be fired."),
                   ("Joseph", "Ah."),
                   ("Thomas", "I suppose this is an important piece of evidence."),
                   ("_obtainEv", "0"),
                   ("_hideObtainedEnv",""),
                   ("_goTo","investigate")
                   //obtain evidence Katie's Letter.

               },
               //3 paper on the wall
               new (string speaker, string dialogue)[]
               {
                   ("Joseph", "A piece of paper on the wall."),
                   ("Joseph", "Looks like a important memo from another company."),
                   ("_goTo","investigate")
               },
               //4 File in cabinet
               new (string speaker, string dialogue)[]
               {
                   ("Joseph", "There's a folder sticking out from the drawers."),
                   ("Joseph", "That's odd, the drawer doesn't have any other folders and she has a holder for folders."),
                   ("Joseph", "It's titled \"Records of That Person\", it has multiple entries of someone not doing their job properly."),
                   ("Joseph", "It has the dates and descriptions but not the name."),
                   ("Joseph", "But I think I know who Katie is referring to."),
                   ("_goTo","investigate")
               },
               //5 Proceeds
               new (string speaker, string dialogue)[]
               {
                   ("Joseph", "I believe that's everything we can investigate here."),
                   ("Joseph", "Jack said something about Katie writing a letter right?"),
                   ("Thomas", "He said \"A letter. I don't know what she was writing, but she was writing a lot.\""),
                   ("Joseph", "So she kept tabs on Jack, and she decided to write a letter to have him fired."),
                   ("Joseph", "Coincidentally, the night she was writing the letter, she was stabbed in the chest."),
                   ("Thomas", "You think Jack knew about the letter and he lied to us?"),
                   ("Joseph", "Unlikely, the fact that the letter is still here means he didn't know."),
                   ("Thomas", "Why is that?"),
                   ("Joseph", "Think about it."),
                   ("Joseph", "If Jack knew about the letter, he has to silence Katie to keep his job."),
                   ("Joseph", "Then, he has to get rid of the evidence."),
                   ("Joseph", "Yet, the letter was just sitting here for 2 days."),
                   ("Thomas", "But the letter and Katie's death are definitely correlated."),
                   ("Joseph", "Either Jack didn't get the opportunity to get rid of the letter..."),
                   ("Joseph", "Or someone is trying to frame him."),
                   ("Thomas", "..."),
                   ("Joseph", "Anyway, Eliot said his desk is on the left, right?"),
                   ("Thomas", "Right."),
                   ("Joseph", "So that's left, right?"),
                   ("Thomas", "Right."),
                   ("Joseph", "...Sometimes I want to just slap you in the face."),
                   ("_nextScene", "Sequence3Pt2")

               }



        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
