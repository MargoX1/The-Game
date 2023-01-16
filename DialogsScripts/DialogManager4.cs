using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogManager4 : MonoBehaviour
{
    public GameObject dialogPanel;
    public TMP_Text dialogText;

    private bool continue_dialog = false;
    public static bool dialogManager4;

    [TextArea(3, 10)]
    [SerializeField] string[] textBlock_1;
    [TextArea(3, 10)]
    [SerializeField] string[] textBlock_2;

    private void Update()
    {
        if ((StoneClick._StoneBinding_carve == true || StoneClick._StoneBinding_draw == true) && DialogManager3.dialogManager3 == true)
        {
            StartCoroutine(RunStudyDialog());
            DialogManager3.dialogManager3 = false;
        }
    }

    IEnumerator RunStudyDialog()
    {
        dialogPanel.SetActive(true);

        for (int i = 0; i < textBlock_1.Length; i++)
        {
            continue_dialog = false;

            string sentence = textBlock_1[i];
            yield return StartCoroutine(WriteSentence(sentence));

            yield return new WaitUntil(() => continue_dialog);

        }

        EndDialog();
        dialogManager4 = true;
    }

    IEnumerator WriteSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(0.01f);

        }
    }

    public void ContinueDialog()
    {
        continue_dialog = true;
    }

    public void EndDialog()
    {
        dialogPanel.SetActive(false);
    }
}

