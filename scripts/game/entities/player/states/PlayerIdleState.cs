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
        float horinzontalInput = _player.inputModule.HorizontalInput;
        bool isMoving = _player.inputModule.IsMoving;

        _player.animationModule.HandleRotatePlayer(horinzontalInput);

        if (isMoving)
            entity.TransitionTo("run");

        if (Input.IsActionJustPressed("player_attack"))
            entity.TransitionTo("attack");
    }

    public override void Exit()
    {
        _player.animationModule.SetIdle(false);
    }
}
