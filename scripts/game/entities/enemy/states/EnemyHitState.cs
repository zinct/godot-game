using Godot;
using System;

public partial class EnemyHitState : State
{
    private Enemy _entity;
    [Export]
    private Timer _timer;
    [Export]
    private RigidBody2D _rigidBody2D;

    public override void Ready()
    {
        _entity = entity as Enemy;
    }

    public override void Enter()
    {
        _entity.knockbackModule.ApplyCentralImpulse(Vector2.Right);
        _entity.TransitionTo("idle");
    }

    public void _on_enemy_sleeping_state_changed()
    {
        if(_rigidBody2D.Sleeping)
        {
        }
    }
}
