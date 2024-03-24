using Godot;
using System;

public partial class PlayerAnimationModule : AnimationModule
{
	public void HandleAnimation(Vector2 direction)
	{
		if (direction.X != 0)
		{
			HandleRotatePlayer(direction.X);
			SetRunning(true);
		}
		else if (direction.Y != 0)
		{
			SetRunning(true);
		}
		else
		{
			SetIdle(true);
		}
	}

	private void SetIdle(bool value)
	{
		Set("parameters/conditions/is_idle", value);
		Set("parameters/conditions/is_running", !value);
		Set("parameters/conditions/is_attack", !value);
	}

	public void SetRunning(bool value)
	{
		Set("parameters/conditions/is_idle", !value);
		Set("parameters/conditions/is_running", value);
		Set("parameters/conditions/is_attack", !value);
	}

	private void SetAttack(bool value)
	{
		Set("parameters/conditions/is_idle", !value);
		Set("parameters/conditions/is_running", !value);
		Set("parameters/conditions/is_attack", value);
	}

	private void HandleRotatePlayer(float direction)
	{
		Set("parameters/attack/blend_position", direction);
		Set("parameters/running/blend_position", direction);
		Set("parameters/idle/blend_position", direction);
	}
}
