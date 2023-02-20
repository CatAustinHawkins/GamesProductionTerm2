using UnityEngine;
using TMPro;
using System.Collections;

public class Dialogue : MonoBehaviour
{
    public GameObject DialogueBox;

    private string CurrentText;

    public string NewText;

    public TextMeshProUGUI NPCName;
    public TextMeshProUGUI DialogueText;

    public GameObject Option1Button;
    public GameObject Option2Button;
    public GameObject Option3Button;

    public TextMeshProUGUI Option1Text;
    public TextMeshProUGUI Option2Text;
    public TextMeshProUGUI Option3Text;

    public int NPCCounter;

    public void DialogueTrigger()
    {
        CurrentText = NewText;
        StartCoroutine(DisplayText());

        switch (NPCCounter)
        {
            case 1:
                Option1Button.SetActive(true);
                Option2Button.SetActive(true);
                Option3Button.SetActive(true);
                Option1Text.text = "Ok";
                Option2Text.text = "...";
                Option3Text.text = "I see";
                break;
        }
    }

    private IEnumerator DisplayText()
    {
        DialogueText.text = "";

        foreach(char c in CurrentText.ToCharArray())
        {
            DialogueText.text += c;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }

    public void Option1()
    {
        switch(NPCCounter)
        {
            case 1:
                NewText = "Option 1 was clicked.";
                CurrentText = NewText;
                StartCoroutine(DisplayText());
                Option1Button.SetActive(false);
                Option2Button.SetActive(false);
                Option3Button.SetActive(false);
                break;
        }
    }

    public void Option2()
    {
        switch (NPCCounter)
        {
            case 1:
                NewText = "Option 2 was clicked.";
                CurrentText = NewText;
                StartCoroutine(DisplayText());
                Option1Button.SetActive(false);
                Option2Button.SetActive(false);
                Option3Button.SetActive(false);
                break;
        }
    }

    public void Option3()
    {
        switch (NPCCounter)
        {
            case 1:
                NewText = "Option 3 was clicked.";
                CurrentText = NewText;
                StartCoroutine(DisplayText());
                Option1Button.SetActive(false);
                Option2Button.SetActive(false);
                Option3Button.SetActive(false);
                break;
        }
    }
}