using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence3Pt6: MonoBehaviour
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
                ("Joseph", "Jack Willow."),
                ("Jack", "Detective!"),
                ("Jack", "You are back!"),
                ("Jack", "Are you here to free me?"),
                ("Joseph", "I have a few more questions for you."),
                ("Joseph","Would you like to tell me about a certain black box?"),
                ("Jack", "A black box...?"),
                ("Jack", "..."),
                ("_setFace", "mad"),
                ("Jack", "OH A BLACK BOX!"),
                ("Jack", "I AM SO SORRY. I AM SO STUPID!"),
                ("Jack", "YES! The black box!"),
                ("Jack", "It's the gift that my friend gave me!"),
                ("Jack", "It's a knife I wanted to add to my collection for a long time!"),
                ("Joseph", "So at the night of the 7th, you had a knife on you."),
                ("Jack", "Of course!"),
                ("_setFace", "normal"),
                ("Jack", "It was a gift that..my...friend......gave......me......."),
                ("Jack", "Oh..."),
                ("Joseph", "(Oh indeed.)"),
                ("_setFace", "sad"),
                ("Jack", "Ok, I can explain this."),
                ("Jack", "I have completely forgot about this knife."),
                ("Joseph", "Cut the BS."),
                ("Jack", "I am not lying! I didn't have the box when I went home on the 7th."),
                ("Jack", "When I went to the work the next day, it wasn't on my desk either!"),
                ("Jack", "And then Katie's death shocked me. I forgot about the knife then."),
                ("Jack", "Otherwise I would've knew that you guys arrested me for a reason!"),
                ("Jack", "I swear! I didn't have the knife! I didn't kill Katie!"),
                ("Joseph", "I have heard enough."),
                ("Joseph", "I will speak to you when I need to."),
                ("Jack", "Detective Joseph..."),
                ("Officer", "This way, Jack."),
                ("_hideCharacter",""),
                ("Thomas", "So, should we just toss him in jail already?"),
                ("Joseph", "I have my doubts since there is the chance that he didn't have the knife."),
                ("Joseph", "So, that still leaves the possibility that someone framed him by using his knife."),
                ("Joseph", "It is still too soon to make a conclusion."),
                ("Joseph", "There is one more suspect."),
                ("Joseph", "We shall see how that turns the tide."),
                ("_nextScene", "Sequnce 4")
            }
            

            

        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
