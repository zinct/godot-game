using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

[Tool]
public partial class PlayerAttackState : State
{
    // public const float Speed = 300.0f;
    // private float _previousDirection;

    // [Export]
    // private AnimationTree _animationTree;
    // private CharacterBody2D _characterBody2D;

    // public override void Ready()
    // {
    //     _characterBody2D = (CharacterBody2D)GetTree().GetFirstNodeInGroup("PlayerCharacterBody2D");
    // }

    // public override void Enter()
    // {
    //     SetAttack(true);
    // }

    // public override void PhysicsUpdate(double delta)
    // {
    //     Vector2 velocity = _characterBody2D.Velocity;

    //     float horizontalDirection = Input.GetAxis("move_player_left", "move_player_right");
    //     float verticalDirection = Input.GetAxis("move_player_up", "move_player_down");

    //     if (horizontalDirection != 0)
    //         _previousDirection = horizontalDirection;

    //     if (horizontalDirection != 0)
    //         velocity.X = horizontalDirection * Speed;
    //     else
    //         velocity.X = Mathf.MoveToward(velocity.X, 0, 50);

    //     if (verticalDirection != 0)
    //         velocity.Y = verticalDirection * Speed;
    //     else
    //         velocity.Y = Mathf.MoveToward(velocity.Y, 0, 50);

    //     if (horizontalDirection != 0 || verticalDirection != 0)
    //         velocity = velocity.Normalized() * Speed;

    //     _characterBody2D.Velocity = velocity;
    //     _characterBody2D.MoveAndSlide();
    // }


    // public override void Exit()
    // {
    //     SetAttack(false);
    // }

    // private void OnAnimationTreeAnimationFinished(StringName anim_name)
    // {
    //     if (anim_name == "attack_right" || anim_name == "attack_left")
    //         fsm.TransitionTo(fsm.previousState.Name.ToString().ToLower());
    // }

    // public void SetAttack(bool value)
    // {
    //     Set("parameters/conditions/is_attack", value);
    //     Set("parameters/conditions/is_idle", !value);
    //     Set("parameters/conditions/is_running", !value);
    // }

    // public override String[] _GetConfigurationWarnings()
    // {
    //     LinkedList<String> warnings = new LinkedList<String>();

    //     if (_animationTree == null) warnings.AddLast("The PlayerAnimation Node is missing in editor, please add it from the inspector");
    //     return warnings.ToArray<String>();
    // }

}









