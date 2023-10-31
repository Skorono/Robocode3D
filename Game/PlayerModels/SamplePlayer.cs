using AviationAICode.GameObjects;

namespace AICodingGame.PlayerModels;

public abstract class SamplePlayer
{
    protected Inventory _playerInventory;
    
    protected abstract void OnHit();
    
    protected abstract void ScanPlayers();
    
    protected abstract void GroundScan();
    
    
}