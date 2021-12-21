using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt4 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Photo","A picture of Jack found behind Andreas's desk.")
        };

        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;

        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {
                
                ("Joseph", "This is Andreas's desk."),
                ("Joseph", "Jack said she is the hard-working one."),
                ("Joseph", "The shape of this desk is oddly familiar, it's just the color is different."),
                ("Thomas", "I asked the manager, he said that the desks here are ordered to personal preference."),
                ("Thomas", "The cubicles are built in, but the workers decide their desks."),
                ("Joseph", "Interesting...")
            },
            //1 The monitor
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A computer monitor."),
                ("Joseph", "Everyone uses laptops but she gets a computer."),
                ("Joseph", "There's also a post-it on the monitor, "),
                ("Joseph", "It has others' contact informations. Their numbers, emails, etc."),
                ("Joseph", "She has a whole system, I respect that."),
                ("Joseph", "Guess Jack was right about her being an elite."),
                ("_goTo","investigate")
            },
            //2 inbox
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "An inbox for files."),
                ("Joseph", "It also has an post-it on it."),
                ("Joseph", "\"To-do-list.\""),
                ("Joseph", "\"Please put the papers in this box, thank you.\""),
                ("Joseph", "She keeps everything organized, why can't I get more coworkers like her?"),
                ("Thomas", "What are you trying to say?"),
                ("Joseph", "Uhh, nothing? You are a great partner, Thomas."),
                ("Thomas", "...Mhm."),
                ("_goTo","investigate")
            },
            //3 lamp
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A lamp, wait a minute..."),
                ("Joseph", "This lamp seems oddly familiar..."),
                ("Joseph", "Why does it remind me that I am a anime character?"),
                ("_goTo","investigate")
            },
            //4 photo
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Ah yes, random pixels."),
                ("Joseph", "Hey Thomas, what is that behind the desk?"),
                ("Thomas", "Another hidden evidence I suppose."),
                ("", "Thomas reaches for the thing behind the desk."),
                ("Thomas", "It's a picture of Jack."),
                ("Joseph", "What?"),
                ("Thomas", "There's nothing written on the back nor the front."),
                ("Thomas", "It is just a normal picture of Jack."),
                ("_obtainEv", "0"),
                ("_hideObtainedEnv",""),
                ("Joseph", "Weird, why is that behind her desk? Why is she hiding it?"),
                ("Thomas", "Office romance?"),
                ("Joseph", "I need time to digest this."),
                ("_goTo","investigate")
            },
            //5 Proceed
            new (string speaker, string dialogue)[]
            { 
                ("Joseph", "It looks like she is just busy and she is good at her job."),
                ("Joseph", "But why does she have a picture of Jack, and why is she hiding it..."),
                ("Joseph", "The desk...the lamp..."),
                ("Joseph", "Is there some hidden history between the two...?"),
                ("Joseph", "Hmm, oh well. I will figure it out later."),
                ("Joseph", "But now, we have a potential suspect waiting for interrogation."),
                ("_nextScene", "Sequence3Pt5")
            }




        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
