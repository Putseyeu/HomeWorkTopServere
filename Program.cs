using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorTopServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.ExecuteSort();
            Console.ReadLine();
        }
    }

    class Database
    {
        private List<Player> _players = new List<Player>()
        {
            new Player("GARI", 10, 1010),
            new Player("Grom", 11, 1011),
            new Player("Zaz", 80, 9010),
            new Player("Bor", 44, 4500),
            new Player("Ira", 30, 3509),
            new Player("Lelik", 30, 3902),
            new Player("Borovi", 9, 900),
            new Player("Moroz", 37, 3900),
            new Player("Balu", 56, 5310),
            new Player("NeBalu", 70, 7110),
            new Player("Runo", 66, 6034),
            new Player("Zigzag", 21, 2800),
        };

        public void ExecuteSort()
        {
            SortTopPlayersByLevel();
            ShowTopPlayersByPower();
        }

        private void ShowInfo(List<Player> players)
        {
            foreach (Player player in players)
            {
                player.ShowInfo();
            }
        }

        private void SortTopPlayersByLevel()
        {
            int numberMaxTop = 3;
            Console.WriteLine($"Вывод Топ {numberMaxTop} игроков по уровню.");
            var playersTopLevel = _players.OrderByDescending(player => player.Level).Take(numberMaxTop).ToList();
            ShowInfo(playersTopLevel);
        }

        private void ShowTopPlayersByPower()
        {
            int numberMaxTop = 3;
            Console.WriteLine($"Вывод Топ {numberMaxTop} игроков по силе.");
            var playersTopPower = _players.OrderByDescending(player => player.Power).Take(numberMaxTop).ToList();
            ShowInfo(playersTopPower);
        }

    }

    class Player
    {
        public string Name { get;private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string name, int level, int power)
        {
            Name = name;    
            Level = level;
            Power = power;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя игрока -  {Name} / Уровень  {Level} / Сила {Power}");
        }
    }
}
