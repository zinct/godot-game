using Godot;
using System;

public partial class EnemyHealthDebug : Label
{
	[Export]
	public Enemy enemy;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Text = "Health: " + enemy.healthModule.Health;
	}
}
