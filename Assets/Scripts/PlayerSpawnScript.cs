using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawnScript : MonoBehaviour
{
    //creating a list of the spawn points
    public Transform[] spawnPoints;
    private int playerCount;

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        if (spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogError("Spawn points not assigned!");
            return;
        }

        if (playerCount < spawnPoints.Length)
        {
            playerInput.transform.position = spawnPoints[playerCount].position;
            playerCount++;
        }
        else
        {
            Debug.LogWarning("No more spawn points available!");
        }
    }
}
