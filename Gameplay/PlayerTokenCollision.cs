using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    
    /// Fired when a player collides with a token.
    public class PlayerTokenCollision : Simulation.Event<PlayerTokenCollision>
    {
        public PlayerController player;
        public TokenInstance token;

        PlatformerModel platformerModel = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            AudioSource.PlayClipAtPoint(token.tokenCollectAudio, token.transform.position);
        }
    }
}
