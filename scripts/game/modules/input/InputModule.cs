using Godot;
using System;

public partial class InputModule : Node
{
	public float HorizontalInput { get; set; }
	public float VerticalInput { get; set; }
	public Vector2 Direction { get; set; }
	public bool IsMoving { get; set; }
	

	public virtual void HandleInput(double delta)
	{
		// Handle input here in child class..
	}
}
