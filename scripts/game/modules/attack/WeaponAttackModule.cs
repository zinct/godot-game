using Godot;
using System;

public partial class WeaponAttackModule : AttackModule
{
	public void OnBodyEntered(Node2D body)
	{
		foreach (Node child in body.GetChildren())
		{
			if (child is Enemy enemy)
				enemy?.OnDamageReceived(attackDamage);
		}
	}
}
