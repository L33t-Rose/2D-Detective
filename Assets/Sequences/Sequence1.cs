using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence1 : MonoBehaviour
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
        GameData.EVIDENCE_DATA = new(string name, string desc)[]
        {
            ("Autopsy Report","Name: Deez Nuts\nCause Of Death:Deez Nuts")
        };
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            new (string speaker, string dialogue)[]{
                ("_hideCharacter",""),
                ("_hideBG",""),
                ("Joseph", "My name is Joseph Wilson, I am a homicide detective at the Wright Police Department. I have been working for 18 years."),
                ("Joseph", "Like the fish in the sea, detectives come and go. But I remained and I will soon be the Chief of Police. "),
                ("Joseph", "There are many reasons that I made it this far. But there’s one thing that helped me throughout the years."),
                ("Joseph", "I have 2D vision."),
                ("_showBG",""),
                ("Joseph", "In a way, it’s a disability."),
                ("Joseph", "In a way, it’s superhuman vision."),
                ("Joseph", "I have been able to see things others can’t. Details that others missed."),
                ("Joseph", "I have solved the unsolvable and I have possibled the impossible."),
                ("Joseph", "Ok that one was a little weird."),
                ("???", "Hey detective Joseph."),
                ("Joseph", "?"),
                ("_showCharacter",""),
                ("???", "How's it going?"),
                ("Joseph", "This is my partner in crime."),
                ("Joseph", "Get it? Partner? In Crime?"),
                ("Joseph", "His name is Thomas Cottonboot."),
                ("Joseph", "He has been with me for a while."),
                ("Joseph", "He wasn’t my first partner but I have worked with him for a couple of years."),
                ("Joseph", "What is it Thomas?"),
                ("Thomas", "There’s no time to sleep."),
                ("Thomas", "Am I still in 2D for you?"),
                ("Joseph", "Yes, everyday, for the 39th year now."),
                ("Joseph", "If I didn’t know, I would’ve thought the game developers were just bad at art."),
                ("_setFace","smug"),
                ("Thomas", "What?"),
                ("Joseph", "What?"),
                ("Joseph", "Anyway, What is it?"),
                ("Thomas", "A new case. The chief assigned you to do it specifically."),
                ("Joseph", "Great, another Tuesday."),
                ("Thomas", "The murder took place 2 days ago. The victim’s name is Katie Miller. Female, 23 years old. An office worker."),
                ("Thomas", "She was stabbed in the chest, cause of death was loss of blood."),
                ("Thomas", "Here’s the autopsy report."),
                ("_obtainEv", "0"),
                ("_hideObtainedEnv",""),
                ("Joseph", "Who do we have?"),
                ("Thomas", "We have 3 suspects, Jack Willow, Andreas Grace, and Eliot Bernandez. They are Katie’s coworkers and they were staying after work that day for a project."),
                ("Joseph", "Do we have the weapon?"),
                ("Thomas", "We do have the knife. It was left on the victim’s body."),
                ("Joseph", "Do we have any reading on the knife? Any labs done?"),
                ("Thomas", "Way ahead of you. The blood on the knife belonged to the victim and we didn’t find blood samples that belonged to someone else."),
                ("Thomas", "The suspect left their fingerprints on it, it was a match with Jack Willow."),
                ("Joseph", "Seems like an open case."),
                ("Thomas", "The knife also belonged to Jack."),
                ("Joseph", "(Yeah no, either this is really easy or he is one of the generic obvious suspect)"),
                ("Joseph", "Alright, I guess we should do more investigation before Jack goes to court."),
                ("Thomas", "Already have an idea aye?"),
            }
        };
        print("Initialized");
    }

    




//office.transform.localScale = new Vector3(0, 0, 1);
//partner.transform.localScale = new Vector3(0, 0, 1);
}
