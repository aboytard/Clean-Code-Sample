using SOLID.DependencyInversion.Player;

namespace SOLID.DependencyInversion
{
    //1- Constructor Injection Sample 
    public class GameConstruction
    {
        IPlayer _player;
        public GameConstruction(IPlayer player)
        {
            this._player = player;
        }

        public void StartGame()
        {
            _player.Play();
        }
    }
}
