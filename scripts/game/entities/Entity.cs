using Godot;
using System;
using System.Collections.Generic;

public partial class Entity : Node
{
	[Export]
	public State initialState;

	[Signal]
	public delegate void TransitionChangedEventHandler(State previousState, State nextState);

	protected State currentState;
	protected State previousState;
	private Dictionary<String, State> _states;

	public override void _Ready()
	{
		_states = new Dictionary<String, State>();

		foreach (Node node in GetChildren())
		{
			if (node is State s)
			{
				_states[node.Name.ToString().ToLower()] = s;
				s.entity = this;
				s.Ready();
				s.Exit();
			}
		}

		currentState = initialState;
		currentState.Enter();
	}

	public void TransitionTo(String key, dynamic args = null)
	{
		previousState = currentState;
		if (!_states.ContainsKey(key) || currentState == _states[key])
			return;

		currentState.Exit();
		currentState = _states[key];
		currentState.Enter();

		// Emit Signal
		EmitSignal(SignalName.TransitionChanged, previousState, currentState);
	}

	public override void _Process(double delta)
	{
		currentState?.Update(delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		currentState?.PhysicsUpdate(delta);
	}
	public override void _UnhandledInput(InputEvent @event)
	{
		currentState?.UnhandledInput(@event);
	}

}
