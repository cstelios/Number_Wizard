using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessTxt;
    [SerializeField] TextMeshProUGUI guessesTxt;
    
    int guess;
    static int guesses = 1;

    private void Start()
    {
        Guess();
    }

    public void Higher()
    {
        min = guess;
        Guess();
    }

    public void Lower()
    {
        max = guess;
        Guess();
    }

    void Guess()
    {
        guesses += 1;
        guessesTxt.text = guesses.ToString();
        guess = Random.Range(min, max + 1);
        guessTxt.text = guess.ToString();
    }
}
