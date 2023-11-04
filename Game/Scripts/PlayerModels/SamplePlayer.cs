using AICodingGame.Scripts.GameObjects;

namespace AICodingGame.Scripts.PlayerModels;

public abstract class SamplePlayer
{
    protected Inventory _playerInventory;
    
    protected abstract void OnHit();
    
    protected abstract void ScanPlayers();
    
    protected abstract void GroundScan();
    
    
}