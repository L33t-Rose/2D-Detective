using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence2 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;

    //This is where we 
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            
        };
        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;
        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
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
                ("", "Jack takes a seat."),
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
                ("Jack", "Katie and I have been enemies, she thinks I am slacking and I never do work"),
                ("Jack", "I hate those people who thinks you are slacking when you are doing background work."),
                ("Jack", "Like, just because you don't see it, doesn't mean I am not helping."),
                ("Jack", "You guys are probably thinking \"He has history with Katie so he has motive\"."),
                ("Jack", "But you guys have no concrete evidence that I did it."),
                ("Joseph", "(He doesn't think we have concrete evidence...)"),
                ("Joseph", "(Is he stupid?)"),
                ("Joseph", "Alright, what about others?"),
                ("Joseph", "What do you think about Eliot?"),
                ("Jack", "Eliot?"),
                ("_setFace", "judgy"),
                ("Jack", "Biggest simp I've seen."),
                ("Jack", "He always has some brown on his nose. "),
                ("Jack", "Always trying to get on their good side, including the boss."),
                ("Jack", "But he is productive, I will give him that."),
                ("Joseph", "What about Andreas?"),
                ("_setFace", "normal"),
                ("Jack", "She is alright, probably the elite in our company."),
                ("Jack", "Always doing work, smart too."),
                ("Jack", "She is a bit arrogant, she likes to brag about herself especially her piano."),
                ("Jack", "I don't mind that though, she has the skill to back it up."),
                ("Jack", "Unlike somebody."),
                ("_setFace", "judgy")


            },
            //4
            new (string speaker, string dialogue)[] // dialogue after interrogation
            {
                ("_setFace", "normal"),
                ("Joseph", "Alright, it was nice talking to you."),
                ("Joseph", "That will be all for now until we call you again."),
                ("Jack", "Detective Joseph."),
                ("Joseph", "?"),
                ("Jack", "...I am sorry about earlier"),
                ("Jack", "I was just angry that I got arrested for something I didn’t do."),
                ("Jack", "The cops were all suspicious and saying I am obviously the murderer."),
                ("Jack", "I didn’t kill her. I don’t know what happened."),
                ("Jack", "It's been two days and the cops kept treating me like I killed her."),
                ("Jack", "I can tell, you are different."),
                ("Jack", "Please, I am innocent."),
                ("Joseph", "I understand, I will do my best to solve this case."),
                ("Officer", "This way, Jack."),
                ("_hideCharacter",""),
                ("","Jack leaves the room."),
                ("Thomas", "Do you believe him?"),
                ("Thomas", "Do you actually think he didn't do it?"),
                ("Joseph", "With the cards on the table, the game is either over."),
                ("Joseph", "Or someone is going to pull the biggest reverse card on us."),
                ("Joseph", "That someone can very well be Jack."),
                ("Thomas", "...Wow."),
                ("Joseph", "With that, we should go check out their office and find more clues."),
                ("_nextScene", "Sequence3Pt1")

            },
            //5
            new (string speaker, string dialogue)[] //Wall
            { 
                ("Joseph", "(The wall of the interrogation room.)"),
                ("Joseph", "(The color makes the room feel like a dungeon.)"),
                ("Joseph", "(It also feels like a prison.)"),
                ("_goTo","investigate"),
                //("_showCharacter",""),
            },
            //6
            new (string speaker, string dialogue)[]//table
            {
                ("Joseph", "(The table of the interrogation room.)"),
                ("Joseph", "(It feels oddly nice.)"),
                ("Joseph", "(But why did they put a wood table in the interrogation room?)"),
                ("_goTo","investigate"),
                //("_showCharacter","")
            }

        };


        print("Initialized");
    }
    
    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
