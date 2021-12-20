using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceController : MonoBehaviour
{
    public Image EVIDENCE_IMAGE;
    public Text EVIDENCE_NAME;
    public Text EVIDENCE_DESCRIPTION;
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
        print(GameData.EVIDENCE_SPRITES);
        var data = GameData.EVIDENCE_DATA[index];
        var sprite = GameData.EVIDENCE_SPRITES[index];
        EVIDENCE_NAME.text = data.name;
        EVIDENCE_DESCRIPTION.text = data.desc;
        EVIDENCE_IMAGE.sprite = sprite;

        GameData.OBTAINED_EVIDENCE.Add((sprite, data));
        print(GameData.OBTAINED_EVIDENCE);
    }

    void show()
    {
        print("showing");
        var pos = transform.position;
        Debug.Log("test "+pos);
        //Why does this work? Who knows?
        pos.y = 0+384;
        transform.position = pos;
    }

    void hide()
    {
        var pos = transform.position;
        pos.y = -600;
        transform.position = pos;
    }
}
