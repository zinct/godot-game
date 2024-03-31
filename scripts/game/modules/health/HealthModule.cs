using Godot;
using System;

public partial class HealthModule : Node
{
	[Export]
	public float _health = 100f;
	public float Health
	{
		get => _health;
		set
		{
			if (_health - value <= 0)
			{
				_health = 0;
				EmitSignal(SignalName.HealthDepleted);
			}
			else _health = value;
		}
	}

	[Signal]
	public delegate void HealthDepletedEventHandler();
}
