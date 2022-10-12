using Platformer.Core;
using Platformer.Model;

namespace Platformer.Gameplay
{
    /// <summary>
    /// This event is fired when user input should be enabled.
    /// </summary>
    public class EnablePlayerInput : Simulation.Event<EnablePlayerInput>
    {
        PlatformerModel platformerModel = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var player = platformerModel.player;
            player.controlEnabled = true;
        }
    }
}