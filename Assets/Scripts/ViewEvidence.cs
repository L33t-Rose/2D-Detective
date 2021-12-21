using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ViewEvidence : MonoBehaviour
{
    public GameObject canvas;
    public GameObject Scroll;

    public Button presentButton;
    public Button EvidenceButton;

    public Text EVIDENCE_NAME;
    public Text EVIDENCE_CONTENT;

    Vector3 SHOW_VECTOR = new Vector3(1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        //loadEvidence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPresentButton()
    {
        if (SceneManager.GetActiveScene().name.Equals("Sequence5")) {
            presentButton.transform.localScale = SHOW_VECTOR;
        }
    }

    void loadEvidence()
    {
        Scroll.transform.DetachChildren();
        var test = GameData.OBTAINED_EVIDENCE;
        foreach (var temp in test)
        {
            Button button = Instantiate(EvidenceButton, Scroll.transform,false);
            var evidence_image = button.transform.GetChild(0);
            var evidence_image_component = evidence_image.GetComponentInChildren<Image>();
            evidence_image_component.sprite = temp.image;
            button.onClick.AddListener(() => { showDetails(temp.details); });
            button.onClick.AddListener(showPresentButton);
            print(button.onClick);
        }
    }

    public void showDetails((string name, string desc) details)
    {
        EVIDENCE_NAME.text = details.name;
        EVIDENCE_CONTENT.text = details.desc;
        GameData.evidenceAboutToPresented = details.name;
    }

    public void present()
    {
        var nameOfEvidence = GameData.correctAnswers[GameData.FINAL_SCENE_INDEX];
        var options = GameData.options[GameData.FINAL_SCENE_INDEX];
        if (nameOfEvidence.Equals(GameData.evidenceAboutToPresented))
        {
            canvas.SendMessage("showTextbox", options.correct);
            GameData.FINAL_SCENE_INDEX += 1;
        }
        else
        {
            canvas.SendMessage("showTextbox", options.incorrect);
        }
    }
}
