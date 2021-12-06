using UnityEngine;
using UnityEngine.UI;

public class DisplayDialogue : MonoBehaviour
{
    public GameObject dialogueContainer;
    public Text dialogueTextRef;

    public void DisplayText(string s)
    {
        dialogueContainer.SetActive(true);
        dialogueTextRef.text = s;
    }

    public void HideText()
    {
        dialogueContainer.SetActive(false);
    }

}
