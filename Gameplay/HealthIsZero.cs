using Platformer.Core;
using Platformer.Mechanics;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{
    
    /// Fired when the player health reaches 0. This usually would result in a 
    /// PlayerDeath event.
    public class HealthIsZero : Simulation.Event<HealthIsZero>
    {
        public Health health;

        public override void Execute()
        {
            Schedule<PlayerDeath>();
        }
    }
}