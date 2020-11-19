using UnityEngine;

public class Player : StateMachine
{
    public MovementState movementState = null;
    public InteractionState interactionState = null;

    private void Awake()
    {
        movementState = new MovementState(this);
        interactionState = new InteractionState(this);
        initialState = movementState;
    }
}