using Platformer.Core;
using Platformer.Model;

namespace Platformer.Gameplay
{
    
    /// This event is fired when user input should be enabled.
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