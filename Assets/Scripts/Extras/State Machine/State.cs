public abstract class State
{
    protected StateMachine source = null;

    public virtual void OnStateEnter() { }
    public virtual void OnStateTick()  { }
    public virtual void OnStateFixedTick()  { }
    public virtual void OnStateExit()  { }

    public abstract override string ToString();

    public State(StateMachine source)
    {
        this.source = source;
    }
}
