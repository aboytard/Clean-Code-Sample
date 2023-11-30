using SOLID.DependencyInversion.Player;

namespace SOLID.DependencyInversion
{
    //3- Method Injection
    public interface IGameInterface
    {
        void StartGame(IPlayer player);
    }

    public class GameInterface : IGameInterface
    {
        private IPlayer _player;
        public void StartGame(IPlayer player)
        {
            this._player = player;
            _player.Play();
        }
    }
}
