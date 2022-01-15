using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue{
    [TextArea]
    public string dialogue;
}
public class Conversation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    

    private bool isDialogue = false;

    private int count = 0;


    [SerializeField] private Dialogue[] dialogue;


    public void ShowDialogue()
    {
        OnOffDialogue(true);

        count = 0;
        NextDialogue();
    }


    private void OnOffDialogue(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);

        isDialogue = _flag;
    }


    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        count++;
    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    OnOffDialogue(false);
            }
        }
    }
}
