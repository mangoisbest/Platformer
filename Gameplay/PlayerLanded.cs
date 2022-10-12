using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    
    /// Fired when the player character lands after being airborne.
    public class PlayerLanded : Simulation.Event<PlayerLanded>
    {
        public PlayerController player;

        public override void Execute()
        {

        }
    }
}