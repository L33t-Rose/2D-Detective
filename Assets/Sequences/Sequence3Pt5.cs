using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt5 : MonoBehaviour
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
                ("Joseph", "Eliot Bernandez."),
                ("Eliot", "Y-Yes officer."),
                ("Joseph", "We have a few simple questions, I just want to remind you that everything you say will be admissiable in court."),
                ("Eliot", "Y-Yes sir.")
            },
            //1 What happened?
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "Where were you on the night of the 7th?"),
                ("Eliot", "I was working in this office with Katie, Andreas, and Jack."),
                ("Eliot", "We were working on the presentation for a meeting next week with another company."),
                ("Eliot", "It's for a product that we will sell. We have to convince them to fund us, so I was working harder than usual."),
                ("Joseph", "What happened during that meeting?"),
                ("Eliot", "I was working with Andreas. But Jack and Katie weren't helping."),
                ("Joseph", "What do you mean?"),
                ("Eliot", "Katie was writing a letter, she seemed really worked up and she was flipping through her files while writing it."),
                ("Eliot", "I don't know what she was writing, but it was definitely important since it took her a long time."),
                ("Eliot", "Jack on the other hand, he was fiddling with a black box."),
                ("Joseph", "A black box?"),
                ("Eliot", "Y-Yes. Inside the black box was a knife."),
                ("Joseph", "He was fiddling with a box that has a knife inside it. How do you know?"),
                ("Eliot", "He was talking about how he got this gift from a friend, and it's a knife he wanted for a long time."),
                ("Joseph", "(A black box with a knife inside. Jack didn't mention any of this. Hmmm.)")
            },
            //2 Alibi
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "When did you leave office?"),
                ("Eliot", "I left at around 8:10."),
                ("Joseph", "How do you know exactly?"),
                ("Eliot", "We have a machine that keeps a log of check-ins and check-outs."),
                ("Eliot", "It also shows what time it was when we interact with it, that's how I knew it was around 8:10."),
                ("Joseph", "Is it possible for us to get a copy of that log?"),
                ("Eliot", "Sure, you can speak to my manager and they can get you one."),
                ("Joseph", "Thomas, can you go fetch one?"),
                ("Thomas", "Why did you say that like I am a K9?"),
                ("", "Thomas left."),
                ("Joseph", "Do you remember the order of the those who left the office that day?"),
                ("Eliot", "Yes, I was the last one to leave the office. Our meeting ended at 7 pm, but there were a few things I wanted to add, so I stayed until 8 pm."),
                ("Eliot", "The first one to leave was Jack."),
                ("Eliot", "Katie left with Jack, and then Andreas left shortly after that."),
                ("Joseph", "So Jack left first, Katie followed him, and Andreas left shortly after."),
                ("Eliot", "That is correct."),
                ("Joseph", "Where did you go after you left?"),
                ("Eliot", "I called an Albur and I went home."),
                ("Joseph", "Do you have any proof that you called an Albur?"),
                ("Eliot", "Yes, I have the receipt on my mobile app."),
                ("Joseph", "(Hmm, a watertight alibi.)")
            },
            //3 Letter
            new (string speaker, string dialogue)[]
            { 
                ("Joseph", "What is your relation with Katie?"),
                ("Eliot", "Um, she is my coworker."),
                ("Joseph", "We have evidence suggesting you have other connections to Katie."),
                ("_setFace","blushing"),
                ("Eliot", "What do you mean?"),
                ("Joseph", "I suggest you be honest and tell us about it."),
                ("Eliot", "OK! OK!"),
                ("Eliot", "I like Katie."),
                ("Eliot", "She is the most beautiful woman I have seen."),
                ("Eliot", "I want to be with her but I never got the courage to say it."),
                ("Joseph", "(I didn't know this turned into a shojo anime.)"),
                ("Joseph", "(Wait, SO I AM AN ANIME CHARACTER!)"),
                ("Eliot", "But I finally decided to express my feelings."),
                ("Eliot", "I wrote a letter with everything I wanted to tell Katie."),
                ("Eliot", "And I wanted to give it to her on the 7th, at the end of our meeting."),
                ("Eliot", "But before I could talk to her and give it to her, she left."),
                ("_setFace", "normal"),
                ("Eliot", "It looked like she was in a rush."),
                ("Eliot", "So I ended up not delivering her the letter."),
                ("Eliot", "The next day, I didn't find her at work. And then I heard she was killed."),
                ("_setFace", "sad"),
                ("Eliot", "I was devasted to know my feelings would never be expressed."),
                ("Eliot", "I can only live in regret."),
                ("Joseph", "I am sorry to hear that."),
                ("Eliot", "Please, officer."),
                ("Eliot", "I know that Jack killed her."),
                ("Eliot", "He hated Katie and he must've killed her when he thought no one will see him. And he happened to have a knife on him."),
                ("Eliot", "It is clear that Jack is the killer. Please put him in jail for life."),
                ("Eliot", "For Katie."),
                ("Joseph", "I will do my best to find Katie's killer and bring them to justice.")
            },
            //4 flower
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
            //5 coffee
            new (string speaker, string dialogue)[]
            {
                ("Joseph", "That's a cup of PlanetPennies."),
                ("Josepj", "Typical coffee for a office worker."),
                ("_goTo","investigate")
            },
            //6 Proceeed
            new (string speaker, string dialogue)[]
            {
                ("_setFace", "normal"),
                ("Joseph", "Thank you, Eliot."),
                ("Joseph", "That will be all the questions I have, thank you for cooperating."),
                ("Eliot", "No problem sir. Please have Jack placed in jail, a death penalty even."),
                ("Joseph", "I understand your frustration."),
                ("Joseph", "I will do my best."),
                ("_hideCharacter", ""),
                ("", "Joseph left."),
                ("Thomas", "Hey Joseph, I got a copy of the log."),
                //obtained evidence.
                ("Joseph", "Thank you so much."),
                ("Thomas", "So what did you learn?"),
                ("Joseph", "Eliot didn't do it."),
                ("Thomas", "Are you sure?"),
                ("Joseph", "He has a watertight alibi. He didn't deliver the letter and he is sad that he can't anymore."),
                ("Thomas", "Wow, I feel bad for the guy."),
                ("Thomas", "Where to now?"),
                ("Joseph", "We have to pay our friend another visit."), 
                ("_nextScene", "Sequence3Pt6")

            }

        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
