using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using TMPro;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player collides with a token.
    /// </summary>
    /// <typeparam name="PlayerCollision"></typeparam>
    public class PlayerTokenCollision : Simulation.Event<PlayerTokenCollision>
    {
        public PlayerController player;
        public TokenInstance token;
        int currScore = 0;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();
        // Tex score = GameObject respawn = GameObject.FindGameObjectsWithTag("Spawn Point")[0];
        TextMeshProUGUI score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();


        public override void Execute()
        {
            AudioSource.PlayClipAtPoint(token.tokenCollectAudio, token.transform.position);
            currScore++;
            score.text = "Score: " + currScore;
        }
    }
}