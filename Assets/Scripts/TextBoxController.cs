using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
{
    public Text speakerText;
    public Text dialogueText;
    public Canvas canvas;

    public Animator anim;

    (string speaker, string dialogue)[] test;
    (string speaker, string dialogue)[] Sequence1;
    (string speaker, string dialogue)[] currentSequence;
    (string speaker, string dialogue) current;
    int currentIndex = 0;

    string goTo;

    // Start is called before the first frame update
    void Start()
    {
        goTo = "";
    }

    bool isCurrentACommand()
    {
        return current.speaker.StartsWith("_");
    }


    void LoadDialogue(int index)
    {
        currentIndex = 0;
        currentSequence = GameData.Sequence[index];
        current = currentSequence[currentIndex];
        goTo = "";
        if (isCurrentACommand())
        {
            useCommand(current);
        }
        else
        {
            showCurrent();
        }
    }

    void useCommand((string speaker, string dialogue) com)
    {
        bool autoNext = false;
        switch (com.speaker)
        {
            case "_hideBG":
                autoNext = true;
                canvas.SendMessage("hideBackground");
                break;
            case "_showBG":
                autoNext = true;
                canvas.SendMessage("showBackground");
                break;
            case "_hideCharacter":
                autoNext = true;
                canvas.SendMessage("hideCharacter");
                break;
            case "_showCharacter":
                autoNext = true;
                canvas.SendMessage("showCharacter");
                break;
            case "_setFace":
                autoNext = true;
                canvas.SendMessage("changeFace",com.dialogue);
                //0: Normal
                //1: Smug
                //2: Mad
                //3: Judgy
                //4: Sad
                //5: Nothing
                //6: Blushing
                break;
            case "_obtainEv":
                canvas.SendMessage("obtainEvidence",com.dialogue);
                break;
            case "_hideObtainedEnv":
                autoNext = true;
                canvas.SendMessage("hideObtainedEvidence");
                break;
            case "_goTo":
                autoNext = true;
                goTo = com.dialogue;
                break;
            case "_nextScene":
                canvas.SendMessage("loadNextScene",com.dialogue);
                break;
            case "_clearInteractions":
                autoNext = true;
                GameData.visited.Clear();
                GameData.REQUIRED_INTERACTIONS.Clear();
                break;




        }
        if (autoNext)
        {
            getNextText();
            return;
        }
    }

    void showCurrent()
    {
        speakerText.text = current.speaker;
        dialogueText.text = current.dialogue;
    }

    void getNextText()
    {
        currentIndex += 1;
        if (currentIndex <= currentSequence.Length-1)
        {
            current = currentSequence[currentIndex];
            if (isCurrentACommand())
            {
                useCommand(current);
                return;
            }
            showCurrent();
        }
        else
        {
            if (goTo.Equals(""))
                canvas.SendMessage("showMain");
            else if (goTo.Equals("investigate"))
                canvas.SendMessage("showInvestigate");
            else if (goTo.Equals("evidence"))
                canvas.SendMessage("showEvidence");
        }
    }

}
