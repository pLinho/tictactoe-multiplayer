namespace NsinovaManager
{
    public class Mapa
    {
        List<Player> players;

        void adicionarPlayer(string name) { 
        }
    }

    public class Player
    {
        int id;
        string name;
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

    }
}
