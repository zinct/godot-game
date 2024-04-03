using System;

public partial class PlayerLogic
{
    public interface IState : IStateLogic { }

    public abstract partial record State : StateLogic, IState { }
}