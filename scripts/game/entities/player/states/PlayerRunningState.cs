using Godot;

public partial class PlayerRunningState : State
{
    private Player _player;

    public override void Ready()
    {
        _player = entity as Player;
    }

    public override void Enter()
    {
        _player.animationModule.SetRunning(true);
    }

    public override void Update(double delta)
    {
        _player.inputModule.HandleInput(delta);
        bool isMoving = _player.inputModule.IsMoving; 
        float horinzontalInput = _player.inputModule.HorizontalInput;

        _player.animationModule.HandleRotatePlayer(horinzontalInput);

        if (Input.IsActionJustPressed("player_attack"))
            entity.TransitionTo("attack");

        if (!isMoving)
            entity.TransitionTo("idle");
    }

    public override void PhysicsUpdate(double delta)
    {
        _player.inputModule.HandleInput(delta);
        Vector2 direction = _player.inputModule.Direction;
        _player.movementModule.HandleMovement(delta, direction);
    }

    public override void Exit()
    {
        _player.animationModule.SetRunning(false);
    }
}
