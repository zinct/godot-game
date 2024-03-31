using Godot;
using System;

public partial class DamageModule : Node
{
	[Signal]
	public delegate void DamageReceivedEventHandler();

	public void Hit(float damage)
	{

	}
}
