using UnityEngine;

[CreateAssetMenu(fileName = "StatsMenu", menuName = "Scriptable Objects/StatsMenu")]
public class StatsMenu : ScriptableObject
{
    public string nomeMenu;
    public int exp;
    public int health;
    public string lvl;
}