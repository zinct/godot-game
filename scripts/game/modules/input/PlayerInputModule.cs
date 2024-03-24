using Godot;
using System;

public partial class PlayerInputModule : InputModule
{
	public override void HandleInput(double delta)
	{
		HorizontalInput = Input.GetAxis("move_player_left", "move_player_right");
		VerticalInput = Input.GetAxis("move_player_up", "move_player_down");
		Direction = new Vector2(HorizontalInput, VerticalInput);
	}
}
