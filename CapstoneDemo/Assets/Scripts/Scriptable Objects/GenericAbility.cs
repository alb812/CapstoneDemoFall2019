using UnityEngine;
using UnityEngine.Playables;

[CreateAssetMenu(menuName = "Scriptable Objects/Abilities/Generic Ability", fileName = "New Generic Ability")]
public class GenericAbility : ScriptableObject
{
  public float magicCost;
  public float duration;

  public float playerMagic;
  public Notification usePlayerMagic;
  
  
}
