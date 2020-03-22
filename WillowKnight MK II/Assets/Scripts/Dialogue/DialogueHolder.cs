using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public string Dialogue;
    private DialogueManager DManage;

    public string[] DialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        DManage = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //detects if player is in range of the dialogue box and activates dialogue when hitting E
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //DManage.ShowBox(Dialogue);

                if (!DManage.ActiveDialogue)
                {
                    DManage.DialogueLines = DialogueLines;
                    DManage.CurrentLine = 0;
                    DManage.ShowDialogue();
                }

            }
        }
    }
}
