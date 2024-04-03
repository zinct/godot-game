using Godot;
using System;

public partial class Enemy : Entity
{
    [ExportGroup("Nodes")]
    [Export]
    public HealthModule healthModule;
    [Export]
    public MovementModule movementModule;
    [Export]
    public KnockbackModule knockbackModule;

    public void OnDamageModuleDamageReceived(float damageAmount)
    {
        healthModule.Health -= damageAmount;
        TransitionTo("hit");
    }
}
