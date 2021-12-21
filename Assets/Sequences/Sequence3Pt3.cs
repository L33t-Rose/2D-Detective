using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt3 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Autopsy Report","Name: Katie Miller\nCause Of Death:\nKnife wound to the chest, loss of blood.")
        };

        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;

        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {
               ("Joseph", "This is Jack's desk."),
               ("Joseph", "Looks like a mess over here."),
               ("Joseph", "I wonder if I can even find anything in this paper-infested nest.")
            },
            //1 Paper#1
            new (string speaker, string dialogue)[]
            { 
                ("Joseph", "Messy Paper#1."),
                ("Joseph", "It's a memo from another company."),
                ("Joseph", "It's the same one Katie has on her wall."),
                ("Joseph", "Different people, different habits I guess."),
                ("_goTo","investigate")

            },
            //2 Paper#2
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Messy Paper#2."),
                ("Joseph", "It's a topic proposal for another project."),
                ("Joseph", "Dated back in July."),
                ("Joseph", "Man, it takes him a long time to make an idea."),
                ("_goTo","investigate")
            },
            //3 Paper#3
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Messy Paper#3."),
                ("Joseph", "It's a memo from the manager."),
                ("Joseph", "\"Hey Jack, can you give me the papers I asked you to write last week? I need them ASAP, thank you. \""),
                ("Joseph", "I can taste the anger behind those words even though they are coated in a thick layer of politeness."),
                ("Joseph", "And I found this important memo on the floor."),
                ("Joseph", "Thank god I don't work in the same office as this guy."),
                ("_goTo","investigate")
            },
            //4 Paper Stacks
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "It's a stack of paper."),
                ("Joseph", "I am not flipping through that pile of paper that's thicker than my philosphy textbook back in college."),
                ("Thomas", "But what if something important is in it?"),
                ("Joseph", "You go look for it then. In fact, you owe me 10 bucks if you can't find anything important in there."),
                ("", "Thomas starts to take apart the stack of paper."),
                ("", "He finds wrinkled paper dated back to 2020."),
                ("", "Some papers had random scribble on them."),
                ("", "A expired coupon for a deli nearby."),
                ("", "A magazine-"),
                ("Thomas", "OK I GIVE UP."),
                ("", "Thomas interrupts the narrator and piled the paper back on the desk."),
                ("Joseph", "Would you like to pay me in cash or card?"),
                ("Thomas", "How did you know there wouldn't be anything in there?"),
                ("Joseph", "Jack's a mess and that's obviously his discard pile. If it's important, he would put it closer to him."),
                ("Joseph", "He was probably too lazy to move those papers, or he want to look like he is busy."),
                ("Thomas", "Damn it."),
                ("Joseph", "If you can't make the payment upfront, I will have to collect a daily interest."),
                ("_goTo","investigate")
            },
            //5 Lamp
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A black lamp."),
                ("Joseph", "Looks like those lamps Japanese students use when studying in anime."),
                ("Joseph", "Wait, if anime is 2D."),
                ("Joseph", "And I am in 2D...DOES THAT MAKE ME A ANIME CHARACTER?"),
                ("", "Joseph obtained an identity crisis."),
                ("_goTo","investigate")
            },
            //6 Trash Can
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "A trash can."),
                ("Joseph", "How ironic, someone as messy as him has a trash can."),
                ("Joseph", "It looks like it hasn't been thrown out in days."),
                ("Joseph", "Makes sense."),
                ("_goTo","investigate")
            },
            //7 Proceed
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "All I learned here, was that Jack is a messy slacky worker."),
                ("Joseph", "It makes sense why Katie hates him and wants him fired."),
                ("Thomas", "And he said he works in the background."),
                ("Joseph", "Yeah right, like the useless applications running in the background on my laptop."),
                ("Joseph", "But judging from this, something is off."),
                ("Thomas", "?"),
                ("Joseph", "We can't find anything incriminating. There's almost not a thing that ties him to Katie."),
                ("Thomas", "So...?"),
                ("Joseph", "That means he must've got rid of them. It makes him more suspicious."),
                ("Joseph", "Something is definitely up, and it isn't up-man."),
                ("Thomas", "What's up-"),
                ("Joseph", "nOt mUcH, wAt sUP wIF yOU?"),
                ("Thomas", "AHHHHHHHHHHHHHHHHHHHHHHHH"),
                ("_clearInteractions",""),
                ("_nextScene","Sequence3Pt4")
            }


              

               



        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
