using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    
    /// Fired when a player enters a trigger with a DeathZone component.
    public class PlayerEnteredDeathZone : Simulation.Event<PlayerEnteredDeathZone>
    {
        public DeathZone deathZone;

        PlatformerModel platformerModel = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            Simulation.Schedule<PlayerDeath>(0);
        }
    }
}