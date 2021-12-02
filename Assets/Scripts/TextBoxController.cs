using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
{
    public Text speakerText;
    public Text dialogueText;

    public (string, string) fuck;


    (string speaker, string dialogue)[] test;
    (string speaker, string dialogue) current;
    int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        test = new (string speaker, string dialogue)[]{
            ("Cellular","Brrring... Briiiing"),
            ("Cellular","*beep*"),
            ("???","Hello? This is Maya."),
            ("Mia","Hey Maya, it's me."),
            ("???","Mia! What's up? You haven't called in a while."),
            ("Mia","Sorry, I've been so busy. How you been."),
            ("???","Well, LONELY. And it's all YOUR fault. Nah, I'm just teasing. I've been great! I'm finally getting used to having my own place."),
            ("Mia","That's good to hear. Actually, I'm calling because I have a favor to ask."),
            ("???","I know, I know. YOu want me to hold evidence for you?"),
            ("Mia","Sharp as always! There's a lot of vuzz about the upcoming trial... I just don't feel safe keeping the ecivece here."),
            ("???","I gotcha. So, what is it this time?"),
            ("Mia","It's... a clock"),
            ("???","A clock?"),
            ("Mia","Yeah, it's made to look like that statue, \"The Thinker.\"And it tells you the time! I thought you might like it. You always liked toys"),
            ("???","Hey! I'm not a little girl anymore, Sis!"),
            ("Mia","Now, now. YOu know I'm only teasing. Ah, I should probably teel you, the clock isn't talking right now."),
            ("???","Huh? It's not working? That's lame!"),
            ("Mia","I had to take the clockwork out. Sorry, I put some papers inside it instead."),
            ("???","Papers? Is that the evidence, then? Hmmmm, well... there's a possibility that it might tour out that way,yes.")

        };

        current = test[0];

        showCurrent();

        Debug.Log(speakerText.name);
        Debug.Log(dialogueText.name);
    }

    void showCurrent()
    {
        speakerText.text = current.speaker;
        dialogueText.text = current.dialogue;
    }

    void getNextCurrent()
    {
        print("clicked");
        print($"Current index before {currentIndex}");
        currentIndex += 1;
        print($"Current index after {currentIndex}");
        if (currentIndex >= test.Length)
        {
            return;
        }
        current = test[currentIndex];
        showCurrent();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    time -= Time.deltaTime;
    //    if (time <= 0)
    //    {
    //        getNextCurrent();
    //        time = 5.0f;
    //    }
       

    //}


}
