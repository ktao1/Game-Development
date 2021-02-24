using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    Text textComponent;

    [SerializeField]
    State startingState;

    State state;

    int[] oddNumbers = { 1, 3, 5 };

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
