using AICodingGame.Scripts.GameObjects;
using Godot;

namespace AICodingGame.Scripts.Items.Weapons;

public class BaseGun: GameItem
{
    public enum AmmunitionType
    {
        
    }
    
    public BaseGun()
    {
        Type = ItemType.Gun;
    }
    
    [Export] public int FireForce { get; set; }
    [Export] public AmmunitionType AmmoType { get; set; }
    [Export] public int GunStoreSize { get; set; }
}