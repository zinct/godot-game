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
        float latestHorizontalInput = _player.inputModule.LatestHorizontalInput;

        _player.animationModule.HandleRotatePlayer(latestHorizontalInput);

        if (_player.inputModule.IsAttackInput)
            entity.TransitionTo("attack");

        if (!isMoving)
            entity.TransitionTo("idle");
    }

    public override void PhysicsUpdate(double delta)
    {
        _player.movementModule.HandleMovement(delta, _player.inputModule.Direction);
    }

    public override void Exit()
    {
        _player.animationModule.SetRunning(false);
    }
}
