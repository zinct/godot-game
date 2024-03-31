using Godot;

public partial class PlayerIdleState : State
{
    private Player _player;

    public override void Ready()
    {
        _player = entity as Player;
    }

    public override void Enter()
    {
        _player.animationModule.SetIdle(true);
    }

    public override void Update(double delta)
    {
        _player.inputModule.HandleInput(delta);
        float atestHorizontalInput = _player.inputModule.LatestHorizontalInput;
        bool isMoving = _player.inputModule.IsMoving;

        _player.animationModule.HandleRotatePlayer(atestHorizontalInput);

        if (isMoving)
            entity.TransitionTo("run");

        if (_player.inputModule.IsAttackInput)
            entity.TransitionTo("attack");
    }

    public override void PhysicsUpdate(double delta)
    {
        _player.movementModule.HandleMovement(delta, _player.inputModule.Direction);
    }

    public override void Exit()
    {
        _player.animationModule.SetIdle(false);
    }
}
