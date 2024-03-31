using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class PlayerAttackState : State
{
    private Player _player;

    public override void Ready()
    {
        _player = entity as Player;
    }

    public override void Enter()
    {
        _player.animationModule.SetAttack(true);
    }

    public override void Update(double delta)
    {
        _player.inputModule.HandleInput(delta);
    }

    public override void PhysicsUpdate(double delta)
    {
        _player.movementModule.HandleMovement(delta, _player.inputModule.Direction);
    }

    public override void Exit()
    {
        _player.animationModule.SetAttack(false);
    }

    private void OnAnimationTreeAnimationFinished(StringName anim_name)
    {
        if (anim_name == "attack")
            entity.TransitionTo(entity.previousState.Name.ToString().ToLower());
    }
}









