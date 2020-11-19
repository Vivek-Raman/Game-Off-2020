public class InteractionState : State
{
    public InteractionState(StateMachine source) : base(source)
    {
    }

    public override void OnStateEnter()
    {
        // zoom camera

        // start dialogue
    }

    public override string ToString()
    {
        return "InteractionState";
    }
}