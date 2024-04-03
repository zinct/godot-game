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
			_health = value;

			if(_health <= 0)
			{
				_health = 0;
				EmitSignal(SignalName.HealthDepleted);
			}
		}
	}

	[Signal]
	public delegate void HealthDepletedEventHandler();
}
