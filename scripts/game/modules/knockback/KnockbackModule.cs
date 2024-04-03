using Godot;
using System;

public partial class KnockbackModule : Node
{
    [Export]
    public float force = 80f;
    [Export]
    private RigidBody2D _rigidBody2D;

    public void ApplyCentralImpulse(Vector2 direction)
	{
		_rigidBody2D.ApplyCentralImpulse(direction * force);
	}
}
