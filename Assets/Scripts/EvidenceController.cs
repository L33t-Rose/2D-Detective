using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceController : MonoBehaviour
{
    public Text EVIDENCE_NAME;
    public Text EVIDENCE_DESCRIPTION;
    // Start is called before the first frame update
    void Start()
    {
        hide();
        //show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadEvidence((string name, string desc)evidence)
    {
        EVIDENCE_NAME.text = evidence.name;
        EVIDENCE_DESCRIPTION.text = evidence.desc;
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
