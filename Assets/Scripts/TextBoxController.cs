﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
{
    public Text speakerText;
    public Text dialogueText;
    public GameObject office;
    public GameObject partner;
    public Animator anim;

    public (string, string) fuck;//


    (string speaker, string dialogue)[] test;
    (string speaker, string dialogue)[] Sequence1;
    (string speaker, string dialogue)[] currentSequence;
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
        Sequence1 = new (string speaker, string dialogue)[]
        {
            ("Joseph", "My name is Joseph Wilson, I am a homicide detective at the Wright Police Department. I have been working for 18 years."),
            ("Joseph", "Like the fish in the sea, detectives come and go. But I remained and I will soon be the Chief of Police. "),
            ("Joseph", "There are many reasons that I made it this far. But there’s one thing that helped me throughout the years."),
            ("Joseph", "I have 2D vision."),
            ("Joseph", "In a way, it’s a disability."),
            ("Joseph", "In a way, it’s superhuman vision."),
            ("Joseph", "I have been able to see things others can’t. Details that others missed."),
            ("Joseph", "I have solved the unsolvable and I have possibled the impossible."),
            ("Joseph", "Ok that one was a little weird."),
            ("???", "Hey detective Joseph."),
            ("Joseph", "?"),
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
            ("Thomas", "What?"),
            ("Joseph", "What?"),
            ("Joseph", "Anyway, What is it?"),
            ("Thomas", "A new case. The chief assigned you to do it specifically."),
            ("Joseph", "Great, another Tuesday."),
            ("Thomas", "The murder took place 2 days ago. The victim’s name is Katie Miller. Female, 23 years old. An office worker."),
            ("Thomas", "She was stabbed in the chest, cause of death was loss of blood."),
            ("Thomas", "Here’s the autopsy report.")



        };

        office.transform.localScale= new Vector3(0, 0, 1);
        partner.transform.localScale = new Vector3(0, 0, 1);
        anim.SetBool("smugPartner", true);

        currentSequence = Sequence1;

        current = currentSequence[0];

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
        if (currentIndex == 3)
        {
            office.transform.localScale = new Vector3(13.31127f, 10.00116f, 1);
        }
        else if(currentIndex == 11 )
        {
            partner.transform.localScale = new Vector3(7, 7, 1);
        }
        else if(currentIndex == 22)
        {
            anim.SetBool("smugPartner", false);
        }
        print($"Current index after {currentIndex}");
        if (currentIndex >= currentSequence.Length)
        {
            return;
        }
        current = currentSequence[currentIndex];
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
