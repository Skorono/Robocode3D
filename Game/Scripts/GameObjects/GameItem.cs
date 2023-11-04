using Godot;

namespace AICodingGame.Scripts.GameObjects;

public abstract class GameItem
{
    public enum ItemType
    {
        Heal,
        Grenade,
        Gun,
        Ammo,
        Equipment
    }
    
    [Export] public string Name { get; set; }
    [Export] public Sprite3D Mesh { get; set; }
    [Export] public ItemType Type { get; set; }
}