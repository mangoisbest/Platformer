using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    
    /// This event is triggered when the player character enters a trigger with a VictoryZone component.
    public class PlayerEnteredVictoryZone : Simulation.Event<PlayerEnteredVictoryZone>
    {
        public VictoryZone victoryZone;

        PlatformerModel platformerModel = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            platformerModel.player.animator.SetTrigger("victory");
            platformerModel.player.controlEnabled = false;
        }
    }
}