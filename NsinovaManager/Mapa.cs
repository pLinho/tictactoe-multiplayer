namespace NsinovaManager
{
    public class Mapa
    {
        int widht = 800;
        int height = 600;

        List<Player> players = new List<Player>();

        public List<Player> Players { get => players; set => players = value; }
        public int Height { get => height; set => height = value; }
        public int Widht { get => widht; set => widht = value; }

        void adicionarPlayer(string name) {
            Player novo_jogador = new Player();
            novo_jogador.Name = name;
            Random random = new Random();
            novo_jogador.X = random.Next(widht);
            novo_jogador.Y = random.Next(height);

            Players.Add(novo_jogador);
        }
    }

    public class Player
    {
        int id;
        int x;
        int y;
        string name;
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
