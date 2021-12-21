using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ViewEvidence : MonoBehaviour
{
    public Button EvidenceButton;
    public Text EVIDENCE_NAME;
    public Text EVIDENCE_CONTENT;
    public GameObject Scroll;

    
    // Start is called before the first frame update
    void Start()
    {
        //loadEvidence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadEvidence()
    {
        var test = GameData.OBTAINED_EVIDENCE;
        foreach (var temp in test)
        {
            Button button = Instantiate(EvidenceButton, Scroll.transform,false);
            var evidence_image = button.transform.GetChild(0);
            var evidence_image_component = evidence_image.GetComponentInChildren<Image>();
            evidence_image_component.sprite = temp.image;
            button.onClick.AddListener(() => { showDetails(temp.details); });
            print(button.onClick);
        }
    }

    public void showDetails((string name, string desc) details)
    {
        EVIDENCE_NAME.text = details.name;
        EVIDENCE_CONTENT.text = details.desc;
    }
}
