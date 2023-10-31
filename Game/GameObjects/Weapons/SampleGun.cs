using AviationAICode.GameObjects;
using Godot;

namespace AICodingGame.Weapons;

public class SampleGun: GameItem
{
    public enum AmmunitionType
    {
        
    }
    
    public SampleGun()
    {
        Type = ItemType.Gun;
    }
    
    [Export] public int FireForce { get; set; }
    [Export] public AmmunitionType AmmoType { get; set; }
    [Export] public int GunStoreSize { get; set; }
}