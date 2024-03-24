using Godot;
using System;
using System.Collections.Generic;
using System.Linq;


public partial class PlayerIdleState : State
{
    // [Export]
    // private AnimationTree _animationTree;

    // public override void Ready()
    // {
    //     _animationTree.Active = true;
    // }

    // public override void Enter()
    // {
    //     SetIdleAnimation(true);
    // }

    public override void Update(double delta)
    {

        // HandleAnimationRotation(horizontalDirection);

        // bool isMoving = (Mathf.Abs(horizontalDirection) + Mathf.Abs(verticalDirection)) != 0f;

        // if (isMoving)
        //     fsm.TransitionTo("running");

        // if (Input.IsActionJustPressed("player_attack"))
        //     fsm.TransitionTo("attack");
    }

    // public override void Exit()
    // {
    //     SetIdleAnimation(false);
    // }

    // private void SetIdleAnimation(bool value)
    // {
    //     _animationTree.Set("parameters/conditions/is_attack", !value);
    //     _animationTree.Set("parameters/conditions/is_idle", value);
    //     _animationTree.Set("parameters/conditions/is_running", !value);
    // }

    // private void HandleAnimationRotation(float direction)
    // {
    //     if (direction == 0)
    //         return;

    //     Set("parameters/attack/blend_position", direction);
    //     Set("parameters/running/blend_position", direction);
    //     Set("parameters/idle/blend_position", direction);
    // }

    // public override String[] _GetConfigurationWarnings()
    // {
    //     LinkedList<String> warnings = new LinkedList<String>();

    //     if (_animationTree == null) warnings.AddLast("The PlayerAnimation Node is missing in editor, please add it from the inspector");
    //     return warnings.ToArray<String>();
    // }
}
