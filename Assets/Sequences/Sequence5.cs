using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence5 : MonoBehaviour
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
                ("Joseph", "Andreas."),
                ("Andreas", "Detective, is there something you need to tell me."),
                ("Joseph", "I know what you did."),
                ("Andreas", "I am afraid I don't know what you are referring to."),
                ("Joseph", "You killed Katie Miller, and I am here to arrest you."),
                ("Andreas", "Do you have any evidence to prove that I killed her?"),
                ("Andreas", "What reason do I have to kill her?"),
                //present evidence
                //need to present the orange letter
            },
            //1 First evidence Incorrect
            new (string speaker, string dialogue)[]
            {
                ("Andreas", "What is that suppose to prove?"),
                ("Andreas", "I don't see how that proves my motive."),
                ("Andreas", "Aren't you a detective?"),
                ("Joseph", "Ah, sorry. I just pulled out the wrong piece of evidence."),
                ("Joseph", "Here is the one."),
                ("_goTo","evidence")
                //present evidence
            },
            //2 First Evidence Correct
            new (string speaker, string dialogue)[]
            {
                ("Andreas", "What is this letter?"),
                ("Joseph", "This is a letter written by Katie Miller."),
                ("Joseph", "Katie was planning to give it to the manager and have Jack fired."),
                ("Andreas", "So? How does Jack concern me?"),
                ("Andreas", "He is only my coworker. It's true that he is a slacker. I would be happy if he is fired."),
                ("Joseph", "That's not true."),
                ("Andreas", "What?"),
                ("Joseph", "You like Jack."),
                ("Joseph", "In fact, you love him deeply and you are obsessed."),
                ("Joseph", "This proves exactly that."),
                ("_goTo","evidence")
                //present evidence
                //Need to present the photo
            },
            //3 Second Evidence Incorrect
            new (string speaker, string dialogue)[]
            { 
                ("Andreas", "HAHAHA!"),
                ("Andreas", "This is what made you think I love Jack?"),
                ("Andreas", "Detective, you should be a stand-up comedian!"),
                ("Joseph", "I meant, this is the evidence!"),
                ("_goTo","evidence")
            },
            //4 Second Evidence Correct
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "This is a picture of Jack."),
                ("Andreas", "?! How did you find that?"),
                ("Joseph", "I know you hid it behind you desk."),
                ("Joseph", "To think that you have a picture of him and look at it every so often."),
                ("Joseph", "And you use the same kind of desk and lamp as him."),
                ("Joseph", "It proves that you are obsessed with him."),
                ("Joseph", "(You are what they called, a yandere)."),
                ("Joseph", "As someone who loves Jack, you wouldn't want him to leave the office and lose his job."),
                ("Joseph", "So, you decided to kill Katie when you found out she was going to have him fired."),
                ("Andreas", "..."),
                ("Andreas", "Well, now that your theory creates a motive, how could I possibly have killed Katie?"),
                ("Andreas", "I had no ways to kill her."),
                ("Joseph", "How naive."),
                ("Joseph", "You used this to kill her."),
                ("_goTo","evidence")
                //present evidence
                //Need to present the murder weapon
            },
            //5 Third Evidence Incorrect
            new (string speaker, string dialogue)[]
            {
                ("Andreas", "Detective, I have piano rehearsal to attend to."),
                ("Andreas", "Don't waste my time."),
                ("Joseph", "It was only a fluke. This is what you used to kill her."),
                ("_goTo","evidence")
            },

            //6 Third Evidence Correct
            new (string speaker, string dialogue)[]
            {
                ("Andreas", "A knife?"),
                ("Joseph", "You used Jack's knife to stab her."),
                ("Joseph", "You heard him talking about his knife in the black box during the meeting."),
                ("Joseph", "So you stole it and killed Katie with it."),
                ("Andreas", "Stole it? What a joke."),
                ("Andreas", "Jack brough it with him when he left office."),
                ("Andreas", "Plus, I left before Jack. There is no way I could have my hands on that box."),
                ("Joseph", "You say you left before Jack? This proves otherwise."),
                ("_goTo","evidence")
                //present evidence
                //Need to present the log
            },
            //7 Foruth Evidence Incorrect
            new (string speaker, string dialogue)[]
            { 
                ("Andreas", "What does this prove?"),
                ("Andreas", "Do you have bad eye sight or something?"),
                ("Joseph", "(Ouch.)"),
                ("Joseph", "This is the one that proves you wrong!"),
                ("_goTo","evidence")
            },
            //8 Fourth Evidence Correct
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "This is a log from the machine, it states the exact time each person left."),
                ("Joseph", "The time stamp shows that you left after Katie and Jack."),
                ("Joseph", "Plus, Jack already said that he left the knife at the office and he had forgot about it."),
                ("Andreas", "...I can see that you did your homework."),
                ("Andreas", "According to that log, Katie left before me."),
                ("Andreas", "There is the chance that Katie stole the knife."),
                ("Joseph", "(She is on the edge now, there is no reason why Katie would steal the knife.)"),
                ("Joseph", "(But I can easily prove that Katie didn't steal the knife.)"),
                ("Joseph", "(This is it, the last step to take her in.)"),
                ("Joseph", "If Katie did steal the knife, she must've left her fingerprints on it."),
                ("Joseph", "But this shows otherwise."),
                ("_goTo","evidence")
                //present
                //Need to present Knife
            },
            //9  Fifth Evidence Incorrect
            new (string speaker, string dialogue)[]
            {
                ("Andreas", "Please."),
                ("Andreas", "Speak to me when you have collected your thoughts."),
                ("Andreas", "It's a shame to know that the police force has a detective like you."),
                ("Joseph", "I will show you your end!"),
                ("_goTo","evidence")
            },
            //10 Fifth Evidence Correct
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "If she had held the knife in her hands, we would've found her fingerprints on it."),
                ("Joseph", "But the only fingerprints we found on it, was Jack's."),
                ("Andreas", "WHAT!"),
                ("Joseph", "You would think that just proves Jack was the one who killed Katie."),
                ("Joseph", "But since Jack had the box the whole time, it is reasonable for him to open it and play with it."),
                ("Joseph", "Leaving his fingerprints on the knife."),
                ("Joseph", "You, on the other hand."),
                ("Joseph", "You were wearing gloves. So using the knife wouldn't leave your fingerprints on it."),
                ("Joseph", "When you stabbed Katie, you hurt your hand."),
                ("Joseph", "I don't think I need to show you evidence for that."),
                ("Andreas", "...Not like this."),
                ("Andreas", "NOT LIKE THIS!"),
                ("", "Andreas collapsed"),
                
            }

            



        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
