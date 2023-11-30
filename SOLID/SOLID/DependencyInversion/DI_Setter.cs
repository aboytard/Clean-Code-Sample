using SOLID.DependencyInversion.Player;

namespace SOLID.DependencyInversion
{
    //2- Setter Injection Sample
    public class GameSetter
    {
        private IPlayer _player;
        public IPlayer Player { set { _player = value; } }

        public void StartGame()
        {
            _player.Play();
        }
    }
}
