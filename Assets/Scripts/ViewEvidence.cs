using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewEvidence : MonoBehaviour
{
    public GameObject EvidenceButton;

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
        foreach((Sprite image, (string name, string desc)) temp in test)
        {
            var button = Instantiate(EvidenceButton, Scroll.transform,false);
            var evidence_image = button.transform.GetChild(0);
            var evidence_image_component = evidence_image.GetComponentInChildren<Image>();
            evidence_image_component.sprite = temp.image;
        }
    }
}
