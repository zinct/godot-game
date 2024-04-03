

using Godot;

public partial class PlayerLogic
{
    public static class Output
    {
        public static class Animations
        {
            public readonly record struct Idle;
            public readonly record struct Move;
        }

        public readonly record struct VelocityChanged(Vector2 velocity);
    }
}