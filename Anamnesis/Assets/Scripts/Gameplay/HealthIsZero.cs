using UnityEngine;
using Platformer.Core;
using Platformer.Mechanics;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player health reaches 0. This usually would result in a 
    /// PlayerDeath event.
    /// </summary>
    /// <typeparam name="HealthIsZero"></typeparam>
    public class HealthIsZero : Simulation.Event<HealthIsZero>
    {
        public Health health;
        internal GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];

        public override void Execute()
        {
            var pHealth = player.GetComponent<Health>();
            // GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            // foreach (GameObject enemy in enemies)
            // {
            //     var eHealth = enemy.GetComponent<Health>();
            //     if (eHealth.currentHP == 0)
            //     {
            //         EnemyDeath ev = Schedule<EnemyDeath>();
            //     }
            // }
            if (pHealth.currentHP == 0)
            {
                Schedule<PlayerDeath>();
            } 
        }
    }
}