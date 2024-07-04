using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player/Data")]
public class PlayerData : ScriptableObject
{
    [field: SerializeField] public float Speed { get; private set; }
}
