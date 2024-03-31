using Godot;
using System;

public partial class PlayerInputModule : InputModule
{
	public bool IsAttackInput { get; set; } = false;

	public override void HandleInput(double delta)
	{
		HorizontalInput = Input.GetAxis("move_player_left", "move_player_right");
		VerticalInput = Input.GetAxis("move_player_up", "move_player_down");

		IsAttackInput = Input.IsActionJustPressed("player_attack");

		if (HorizontalInput != 0)
			LatestHorizontalInput = HorizontalInput;

		Direction = new Vector2(HorizontalInput, VerticalInput);
		IsMoving = (Mathf.Abs(HorizontalInput) + Mathf.Abs(VerticalInput)) != 0f;
	}
}
