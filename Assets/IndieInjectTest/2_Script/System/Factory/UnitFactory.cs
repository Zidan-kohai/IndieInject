using IndieInject;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    [Inject] private PlayerMovement playerPrefab;

    [Inject] private PlayerMarker playerMarker;

    private PlayerMovement playerInstance;

    public void Start()
    {
        playerInstance = Indie.Fabric.Instantiate(playerPrefab, playerMarker.playerParent);
    }

}
