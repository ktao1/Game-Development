using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{


    [SerializeField]
    int max;
    [SerializeField]
    int min;
    [SerializeField]
    Text guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void heigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void lower()
    {
        max = guess - 1;
        NextGuess();
    }

    void StartGame()
    {
        NextGuess();
        max += 1;
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
