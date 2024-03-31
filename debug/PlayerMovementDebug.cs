using Godot;
using System;

public partial class PlayerMovementDebug : Label
{
	[Export]
	public Player player;

	public override void _Process(double delta)
	{
		Text = "Velocity: " + player.movementModule.Velocity;
	}
}
