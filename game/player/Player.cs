using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;
using System;

public interface IPlayer
{
    public Vector2 GetGlobalInputVector();
}

[SuperNode(typeof(Dependent))]
public partial class Player : CharacterBody2D, IPlayer
{
    public override partial void _Notification(int what);

    #region Exports

    [ExportGroup("Nodes")]
    [Export]
    public AnimationTree AnimationTree { get; set; } = default!;

    [ExportGroup("Movement")]
    [Export]
    public float MoveSpeed { get; set; } = 300f;
    [Export]
    public float Acceleration { get; set; } = 50f;

    #endregion 

    #region State

    public IPlayerLogic PlayerLogic { get; set; } = default!;
    public PlayerLogic.IBinding PlayerBinding { get; set; } = default!;

    #endregion

    public void Setup()
    {
        var settings = new PlayerLogic.Settings(MoveSpeed, Acceleration);

        PlayerLogic = new PlayerLogic(
            player: this,
            settings: settings
        );
    }

    public void OnReady()
    {
        SetPhysicsProcess(true);
        AnimationTree.Active = true;
    }

    public void OnExitTree()
    {
        PlayerLogic.Stop();
        PlayerBinding.Dispose();
    }

    public void OnResolved()
    {
        PlayerBinding = PlayerLogic.Bind();

        PlayerBinding
        .Handle<PlayerLogic.Output.VelocityChanged>(
            (output) => Velocity = output.velocity
        )

        // Animation
        .Handle<PlayerLogic.Output.Animations.Idle>(
            (output) =>
            {
                AnimationTree.Set("parameters/conditions/is_idle", true);
                AnimationTree.Set("parameters/conditions/is_running", false);
                AnimationTree.Set("parameters/conditions/is_attack", false);
            }
        ).Handle<PlayerLogic.Output.Animations.Move>(
            (output) =>
            {
                AnimationTree.Set("parameters/conditions/is_idle", false);
                AnimationTree.Set("parameters/conditions/is_running", true);
                AnimationTree.Set("parameters/conditions/is_attack", false);
            }
        );

        PlayerLogic.Start();
    }

    public void OnPhysicsProcess(double delta)
    {
        GD.Print("ON PHYSIC PROCESS");
        PlayerLogic.Input(new PlayerLogic.Input.PhysicsTick(delta));
        MoveAndSlide();
    }

    public Vector2 GetGlobalInputVector()
    {
        float horizontalInput = Input.GetAxis("move_player_left", "move_player_right");
        float verticalInput = Input.GetAxis("move_player_up", "move_player_down");

        return new Vector2(horizontalInput, verticalInput);
    }
}
