using Godot;
using System;

public partial class Player : Entity
{
    [ExportGroup("Nodes")]
    [Export]
    public InputModule inputModule;
    [Export]
    public MovementModule movementModule;
    [Export]
    public PlayerAnimationModule animationModule;
}
