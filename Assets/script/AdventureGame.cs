using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponenet;
    [SerializeField] State startingState;

    
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponenet.text = state.GetStateStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for(int index =0; index < nextStates.Length; index ++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1+index))
            {
                state = nextStates[index];
            }
        }
        textComponenet.text = state.GetStateStory();
    }
}
