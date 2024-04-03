using Chickensoft.LogicBlocks;
using Chickensoft.LogicBlocks.Generator;

public interface IPlayerLogic : ILogicBlock<PlayerLogic.IState> { }

[StateMachine]
public partial class PlayerLogic : LogicBlock<PlayerLogic.IState>, IPlayerLogic
{
    public override IState GetInitialState() => new State.Disabled();

    public PlayerLogic(IPlayer player, Settings settings)
    {
        Set(player);
        Set(settings);
    }
}
