using AICodingGame.Items.Weapons;

namespace AICodingGame.PlayerModels;

public abstract class ArmoredPlayer: SamplePlayer
{
    private BaseGun Gun { get; set; }
    
    protected abstract void Fire();

    protected abstract void OnReload();
}