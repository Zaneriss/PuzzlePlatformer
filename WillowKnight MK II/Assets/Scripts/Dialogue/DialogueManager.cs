using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{


    public GameObject DialogueBox;
    public Text DialogueText;

    public bool ActiveDialogue;

    public string[] DialogueLines;
    public int CurrentLine;
    private PlayerMovement ThePlayer;

    // Start is called before the first frame update
    void Start()
    {
        ThePlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ActiveDialogue && Input.GetKeyDown(KeyCode.E)) 
        {
            /*
            Debug.Log("dialogue works");
            DialogueBox.SetActive(false);
            ActiveDialogue = false;
            */

            CurrentLine++;
        }

        //deactivates dialogue box when player finishes the final line of dialogue
        if (CurrentLine >= DialogueLines.Length)
        {
            ThePlayer.CanMove = true;
            DialogueBox.SetActive(false);
            ActiveDialogue = false;

            CurrentLine = 0;
            
        }

        DialogueText.text = DialogueLines[CurrentLine];

    }

    public void ShowBox(string Dialogue)
    {
        ActiveDialogue = true;
        DialogueBox.SetActive (true);
        DialogueText.text = Dialogue;
    }
    //activates dialogue box
    public void ShowDialogue()
    {
        ThePlayer.CanMove = false;
        ActiveDialogue = true;
        DialogueBox.SetActive(true);
    }
}
