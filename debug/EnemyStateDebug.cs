using Godot;
using System;

public partial class EnemyStateDebug : Label
{
	[Export]
	public Enemy entity;

	public override void _Process(double delta)
	{
		Text = "State : " + entity.currentState.Name;
	}
}
