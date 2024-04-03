using Godot;
using System;

public partial class DamageModule : Node
{
	[Signal]
	public delegate void DamageReceivedEventHandler(float damageAmount);

	public void Hit(float damage)
	{
		EmitSignal(SignalName.DamageReceived, damage);
	}
}
