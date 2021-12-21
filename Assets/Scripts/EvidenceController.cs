using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceController : MonoBehaviour
{
    public Image EVIDENCE_IMAGE;
    public Text EVIDENCE_NAME;
    public Text EVIDENCE_DESCRIPTION;

    Vector3 HIDE_VECTOR = new Vector3(0, 1, 1);
    Vector3 SHOW_VECTOR = new Vector3(1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadEvidence(int index)
    {
        var data = GameData.EVIDENCE_DATA[index];
        var sprite = GameData.EVIDENCE_SPRITES[index];
        EVIDENCE_NAME.text = data.name;
        EVIDENCE_DESCRIPTION.text = data.desc;
        EVIDENCE_IMAGE.sprite = sprite;

        GameData.OBTAINED_EVIDENCE.Add((sprite, data));
    }

    void show()
    {
        this.gameObject.transform.localScale = SHOW_VECTOR;
        //var pos = transform.position;
        ////Why does this work? Who knows?
        //pos.y = 0+384;
        //transform.position = pos;
    }

    void hide()
    {
        this.gameObject.transform.localScale = HIDE_VECTOR;
        //var pos = transform.position;
        //pos.y = -600;
        //transform.position = pos;
    }
}
