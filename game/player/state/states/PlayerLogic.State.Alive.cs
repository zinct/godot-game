using Godot;

public partial class PlayerLogic
{
    public partial record State : StateLogic, IState
    {
        public record Alive : State, IGet<Input.PhysicsTick>
        {
            public Alive()
            {
                OnEnter<Alive>(
                    previous => Context.Output(new Output.Animations.Idle())
                );
            }

            public IState On(Input.PhysicsTick input)
            {
                GD.Print("Physics Tick ALive");

                var player = Context.Get<IPlayer>();
                var settings = Context.Get<Settings>();

                var direction = player.GetGlobalInputVector();
                var velocity = new Vector2();

                if (direction.X != 0)
                    velocity.X = direction.X * settings.MoveSpeed;
                else
                    velocity.X = Mathf.MoveToward(velocity.X, 0, settings.Acceleration);

                if (direction.Y != 0)
                    velocity.Y = direction.Y * settings.MoveSpeed;
                else
                    velocity.Y = Mathf.MoveToward(velocity.Y, 0, settings.Acceleration);

                if (direction.X != 0 || direction.Y != 0)
                    velocity = velocity.Normalized() * settings.MoveSpeed;

                Context.Output(new Output.VelocityChanged(velocity));
                return this;
            }
        }
    }
}