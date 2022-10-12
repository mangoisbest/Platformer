using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    
    /// Fired when the player performs a Jump.
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            if (player.audioSource && player.jumpAudio)
                player.audioSource.PlayOneShot(player.jumpAudio);
        }
    }
}