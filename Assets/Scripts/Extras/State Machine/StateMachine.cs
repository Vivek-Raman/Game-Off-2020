using System;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State currentState = null;
    public State initialState = null;

    protected void Start()
    {
        currentState = initialState;
    }

    protected void Update()
    {
        currentState?.OnStateTick();
    }

    protected void FixedUpdate()
    {
        currentState?.OnStateFixedTick();
    }

    #if UNITY_EDITOR && true
    private void OnGUI()
    {
        GUILayout.TextArea(currentState.ToString());
    }
    #endif

    public void SetState(State toSet)
    {
        currentState?.OnStateExit();
        currentState = toSet;
        currentState.OnStateEnter();
    }
}
