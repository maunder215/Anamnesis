using Platformer.Core;
using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the health component on an enemy has a hitpoint value of  0.
    /// </summary>
    /// <typeparam name="EnemyDeath"></typeparam>
    public class EnemyDeath : Simulation.Event<EnemyDeath>
    {
        public EnemyController enemy;
        // public TokenInstance token;

        public override void Execute()
        {
            // token = Instantiate(token);
            // token.transform.position = enemy.transform.position;
            enemy._collider.enabled = false;
            enemy.control.enabled = false;
            // PlatformerModel model = Simulation.GetModel<PlatformerModel>();
            if (enemy._audio && enemy.ouch)
            {
                enemy._audio.PlayOneShot(enemy.ouch);
            }
            GameObject respawn = GameObject.FindGameObjectsWithTag("Spawn Point")[0];
            respawn.transform.position = enemy.transform.position;
        }
    }
}