using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static int currentTextBoxIndex = 0;
    public static (string speaker, string dialogue)[][] Sequence;
    public static (int index, string state)[] faces;
    public static (string name, string desc)[] EVIDENCE_DATA;
    public static Sprite[] EVIDENCE_SPRITES;


    public int officeCounter;
    // Start is called before the first frame update
    void Start()
    {
        officeCounter = 0;
    }

    public void updateFace()
    {
        //if (this.GetFace(currentTextBoxIndex).index)
        //{

        //}
    }

    private (int index, string state) GetFace(int index)
    {
        for (int i = 0; i < faces.Length; i++)
        {
            var face = faces[i];
            if (face.index == currentTextBoxIndex)
            {
                return face;
            }
        }
        return (0,null);
    }

    // Update is called once per frame
}
