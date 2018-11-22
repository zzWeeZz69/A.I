using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentence;
    public float typingSpeed;

    public GameObject continueButton;
    public Animator TextDisplayAnim;

    private int index;
    private void Start()
    {
        StartCoroutine(type());
    }

    void Update()
    {
        if(textDisplay.text == sentence[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator type()
    {
        foreach(char letter in sentence[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        TextDisplayAnim.SetTrigger("Change");
        continueButton.SetActive(false);
        if(index < sentence.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(type());
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
  
}
