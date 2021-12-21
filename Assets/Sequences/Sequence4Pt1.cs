using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence4Pt1 : MonoBehaviour
{
    public Sprite[] EVIDENCE_SPRITES;

    //This is where we 
    public string[] _requiredInteractions;

    // Start is called before the first frame update
    void Start()
    {
        GameData.EVIDENCE_DATA = new (string name, string desc)[]
        {
            ("Autopsy Report","Name: Katie Miller\nCause Of Death:Knife wound to the chest, loss of blood.")
        };
        GameData.EVIDENCE_SPRITES = EVIDENCE_SPRITES;
        Debug.Log("list of evidence sprites" + EVIDENCE_SPRITES.Length);
        GameData.REQUIRED_INTERACTIONS = new HashSet<string>(_requiredInteractions);
        Debug.Log("required interaction list " + _requiredInteractions.Length);
        Debug.Log(GameData.REQUIRED_INTERACTIONS.Count);
        GameData.Sequence = new (string speaker, string dialogue)[][]
        {
            //0
            new (string speaker, string dialogue)[]
            {
            
            }


        };


        print("Initialized");
    }

    //office.transform.localScale = new Vector3(0, 0, 1);
    //partner.transform.localScale = new Vector3(0, 0, 1);
}
