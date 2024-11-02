using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "ItemStats")]
public class ItemStats : ScriptableObject
{
    public string ItemName;
    public string Description;
    public string Tag;
    public int Damage;
    public int Value;
    public int Armor;
    
}
