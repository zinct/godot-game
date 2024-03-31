using Godot;
using System;

public partial class Player : Entity
{
    [ExportGroup("Nodes")]
    [Export]
    public PlayerInputModule inputModule;
    [Export]
    public MovementModule movementModule;
    [Export]
    public PlayerAnimationModule animationModule;
}
