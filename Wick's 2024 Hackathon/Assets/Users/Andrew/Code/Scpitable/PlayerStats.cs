using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public string CharacterName;
    public int Health;
    public int XP;
    public int CurrentHealth;
    public int CurrentXP;
    public int Levels;
}
