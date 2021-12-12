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

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameData.Sequence);
        anim.SetBool("smugPartner", true);
        currentSequence = GameData.Sequence[0];
        current = currentSequence[0];
        if (isCurrentACommand())
        {
            useCommand(current);
        }
        else
        {
            showCurrent();
        }
    }

    bool isCurrentACommand()
    {
        return current.speaker.StartsWith("_");
    }

    void useCommand((string speaker, string dialogue) com)
    {
        bool autoNext = false;
        switch (com.speaker)
        {
            case "_hideBG":
                print("hiding bg");
                autoNext = true;
                canvas.SendMessage("hideBackground");
                break;
            case "_showBG":
                print("showing bg");
                autoNext = true;
                canvas.SendMessage("showBackground");
                break;
            case "_hideCharacter":
                print("hiding character");
                autoNext = true;
                canvas.SendMessage("hideCharacter");
                break;
            case "_showCharacter":
                print("hiding character");
                autoNext = true;
                canvas.SendMessage("showCharacter");
                break;
            case "_setFace":
                print("hiding character");
                autoNext = true;
                canvas.SendMessage("changeFace",com.dialogue);
                break;
            case "_obtainEv":
                print("hiding char");
                canvas.SendMessage("obtainEvidence",com.dialogue);
                break;
            case "_hideObtainedEnv":
                autoNext = true;
                canvas.SendMessage("hideObtainedEvidence");
                break;
            case "_nextScene":
                canvas.SendMessage("loadNextScene",com.dialogue);
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
    }

}
