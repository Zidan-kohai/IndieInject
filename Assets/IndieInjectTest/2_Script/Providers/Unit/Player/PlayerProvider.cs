using IndieInject;
using UnityEngine;

public class PlayerProvider : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerPrefab;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private PlayerMarker  playerMarker;


    [Provide(true)]
    public PlayerMovement ProvidePlayer() => playerPrefab;


    [Provide(true)]
    public PlayerData ProvidePlayerData() => playerData;


    [Provide(true)]
    public PlayerMarker ProvidePlayerMarker() => playerMarker;
}
