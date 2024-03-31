using Godot;
using System;

public partial class Enemy : Entity
{
    [ExportGroup("Nodes")]
    [Export]
    public HealthModule healthModule;

    public void OnDamageReceived(float damage)
    {
        TransitionTo("hit");
    }
}
