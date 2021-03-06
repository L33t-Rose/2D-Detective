using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShowable : MonoBehaviour
{
    public GameObject INVESTIGATION_UI;
    public GameObject MAIN_UI;
    public GameObject TALK_UI;
    public GameObject TEXTBOX_UI;
    public GameObject EVIDENCE_LIST_UI;
    public GameObject NEXT_SCENE_BUTTON;

    Vector3 HIDE_VECTOR = new Vector3(0, 1, 1);
    Vector3 SHOW_VECTOR = new Vector3(1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        purgeAll();
        hide(NEXT_SCENE_BUTTON);
        if (GameData.Sequence[0].Length != 0)
        {
            showTextbox(0);
        }
        else
        {
            show(MAIN_UI);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void purgeAll()
    {
        hide(MAIN_UI);
        hide(TALK_UI);
        hide(EVIDENCE_LIST_UI);
        hide(TEXTBOX_UI);
        hide(INVESTIGATION_UI);
    }

    public void showTextbox(int index)
    {
        purgeAll();
        show(TEXTBOX_UI);
        TEXTBOX_UI.SendMessage("LoadDialogue",index);
    }


    public void showInvestigationTextbox(int index)
    {
        purgeAll();
        show(INVESTIGATION_UI);
        show(TEXTBOX_UI);
        TEXTBOX_UI.SendMessage("LoadDialogue", index);

    }

    public void showMain()
    {
        purgeAll();
        show(MAIN_UI);
    }

    public void showTalk()
    {
        purgeAll();
        show(MAIN_UI);
        show(TALK_UI);
    }

    public void showEvidence()
    {
        purgeAll();
        EVIDENCE_LIST_UI.SendMessage("loadEvidence");
        show(EVIDENCE_LIST_UI);
    }

    public void showInvestigate()
    {
        purgeAll();
        show(INVESTIGATION_UI);
    }

    public void showNextSceneButton()
    {
        show(NEXT_SCENE_BUTTON);
    }

    void hide(GameObject ui_elem)
    {
        ui_elem.transform.localScale = HIDE_VECTOR;
    }
    void show(GameObject ui_elem)
    {
        ui_elem.transform.localScale = SHOW_VECTOR;
    }
}
