using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    public GameObject EVIDENCE_UI;
    public GameObject backGround;
    public GameObject character;
    public Animator anim;

    //We want a system that allows us to control the elements in our scene.
    //We can layout the order of events (A sequence) which allows us to perform any action listed.
    //Our TextBox should handle giving evidence. Since it's inline and we can set our rules inside of the 

    void obtainEvidence(string index)
    {
        var indexToInt = int.Parse(index);
        if(indexToInt >= 0)
        {
            EVIDENCE_UI.SendMessage("loadEvidence", indexToInt);
            EVIDENCE_UI.SendMessage("show");
        }
    }

    void hideObtainedEvidence()
    {
        EVIDENCE_UI.SendMessage("hide");
    }

    void hideBackground()
    {
        backGround.SendMessage("hide");
        //backGround.transform.localScale = new Vector3(0, 0, 1);
    }

    void showBackground()
    {
        backGround.SendMessage("show");
        //backGround.transform.localScale = new Vector3(13.31127f, 10.00116f, 1); 
    }

    void hideCharacter()
    {
        character.SendMessage("hide");
        //character.transform.localScale = new Vector3(0, 0, 1);
    }
    void showCharacter()
    {
        character.SendMessage("show");
        //character.transform.localScale = new Vector3(7, 7, 1);
    }

    void changeFace(string state)
    {
        print(state);
        //0: Normal
        //1: Smug
        //2: Mad
        //3: Judgy
        //4: Sad
        int anim_state = 0;
        switch (state)
        {
            case "normal":
                anim_state = 0;
                break;
            case "smug":
                anim_state = 1;
                break;
            case "mad":
                anim_state = 2;
                break;
            case "judgy":
                anim_state = 3;
                break;
            case "sad":
                anim_state = 4;
                break;
        }
        anim.SetInteger("state", anim_state);
    }

    void loadNextScene(string nextScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

    void AddToInteractions(GameObject obj)
    {
        GameData.visited.Add(obj);
    }

    void checkForNextScene()
    {
        if (GameData.REQUIRED_INTERACTIONS.Equals(GameData.visited))
        {

        }
    }
}
