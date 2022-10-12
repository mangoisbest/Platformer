using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    
    //INFO: Fired when the health component on an enemy has a hitpoint value of  0.
    public class EnemyDeath : Simulation.Event<EnemyDeath>
    {
        public EnemyController enemy;

        public override void Execute()
        {
            enemy._collider.enabled = false;
            enemy.control.enabled = false;
            if (enemy._audio && enemy.deathSFX)
                enemy._audio.PlayOneShot(enemy.deathSFX);
        }
    }
}