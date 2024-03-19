using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Awake()
    {
        startGame();
    }

    void startGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        nextGuess();
    }

    void nextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        nextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        nextGuess();
    }
}