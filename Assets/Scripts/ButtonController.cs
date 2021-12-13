using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    public int index;
    Button m_button;
    private void Start()
    {
        m_button = GetComponent<Button>();
        //m_button.onClick.AddListener(SendMessageUpwards("LoadDialogue", index));
    }
}
