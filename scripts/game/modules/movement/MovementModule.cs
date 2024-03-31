using Godot;
using System;

public partial class MovementModule : CharacterBody2D
{
	[Export]
	private float Speed = 300f;

	public void HandleMovement(double delta, Vector2 direction)
	{
		Vector2 velocity = Velocity;

		if (direction.X != 0)
			velocity.X = direction.X * Speed;
		else
			velocity.X = Mathf.MoveToward(velocity.X, 0, 50);

		if (direction.Y != 0)
			velocity.Y = direction.Y * Speed;
		else
			velocity.Y = Mathf.MoveToward(velocity.Y, 0, 50);

		if (direction.X != 0 || direction.Y != 0)
			velocity = velocity.Normalized() * Speed;

		Velocity = velocity;
		MoveAndSlide();
	}

	public void SetVelocityToZero()
	{
		Velocity = Vector2.Zero;
	}
}
