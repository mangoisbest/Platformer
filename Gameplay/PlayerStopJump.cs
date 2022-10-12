using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    
    /// Fired when the Jump Input is deactivated by the user, cancelling the upward velocity of the jump.
    public class PlayerStopJump : Simulation.Event<PlayerStopJump>
    {
        public PlayerController player;

        public override void Execute()
        {

        }
    }
}