using Godot;

public partial class PlayerLogic
{
    public static class Input
    {
        public readonly record struct Enable;
        public readonly record struct StartedMoving;
        public readonly record struct PhysicsTick(double delta);
    }
}