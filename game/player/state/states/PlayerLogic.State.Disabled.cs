using Godot;

public partial class PlayerLogic
{
    public partial record State : StateLogic, IState
    {
        public record Disabled : State, IGet<Input.Enable>
        {
            public Disabled()
            {
                OnEnter<Alive>(
                    previous => Context.Output(new Output.Animations.Idle())
                );
            }

            public IState On(Input.Enable input) => new Idle();

            public void OnGameEntered() => Context.Input(new Input.Enable());
        }
    }
}