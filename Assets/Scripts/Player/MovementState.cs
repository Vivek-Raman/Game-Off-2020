public class MovementState : State
{
    private PlayerMovement movement = null;

    public MovementState(StateMachine source) : base(source)
    {
        movement = source.GetComponent<PlayerMovement>();
    }

    public override void OnStateEnter()
    {
        movement.enabled = true;
    }

    public override void OnStateExit()
    {
        movement.enabled = false;
    }

    public override string ToString()
    {
        return "MovementState";
    }
}