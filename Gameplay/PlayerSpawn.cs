using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    
    /// Fired when the player is spawned after dying.
    public class PlayerSpawn : Simulation.Event<PlayerSpawn>
    {
        PlatformerModel platformerModel = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var player = platformerModel.player;
            player.collider2d.enabled = true;
            player.controlEnabled = false;
            if (player.audioSource && player.respawnAudio)
                player.audioSource.PlayOneShot(player.respawnAudio);
            player.health.Increment();
            player.Teleport(platformerModel.spawnPoint.transform.position);
            player.jumpState = PlayerController.JumpState.Grounded;
            player.animator.SetBool("dead", false);
            platformerModel.virtualCamera.m_Follow = player.transform;
            platformerModel.virtualCamera.m_LookAt = player.transform;
            Simulation.Schedule<EnablePlayerInput>(2f);
        }
    }
}