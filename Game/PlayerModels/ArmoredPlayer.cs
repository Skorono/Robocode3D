using AICodingGame.Weapons;

namespace AICodingGame.PlayerModels;

public abstract class ArmoredPlayer: SamplePlayer
{
    private SampleGun Gun { get; set; }
    
    protected abstract void Fire();

    protected abstract void OnReload();
}