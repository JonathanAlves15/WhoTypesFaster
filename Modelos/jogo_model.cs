using System;
using System.Collections.Generic;
using System.Linq;
namespace Modelos
{
    public class JogoModel(PlayerModel[] players)
    {
        public PlayerModel[] Players = players;
        public bool Started = false;

        public static int QtdPlayers(PlayerModel[] players) {
            return players.Length;
        }

        public void StartGame() {
            if (QtdPlayers(this.Players) > 1)
                this.Started = true;
            else
                this.Started = false;
        }
    }
}
