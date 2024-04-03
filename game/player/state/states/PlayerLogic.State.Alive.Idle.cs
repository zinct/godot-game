public partial class PlayerLogic
{
    public abstract partial record State
    {
        public record Idle : Alive { }
    }
}