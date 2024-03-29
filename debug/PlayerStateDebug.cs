using Godot;
using System;

public partial class PlayerStateDebug : Label
{
    [Export]
    public Player player;

    public override void _Process(double delta)
	{
        Text = "State : " + player.currentState.Name;
	}
}
