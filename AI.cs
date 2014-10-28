using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;


namespace AI
{
    public class Program
    {
        // Champion Name
        public const string ChampionName = "Caitlyn";

        // Orbwalker
        public static Orbwalking.Orbwalker Orbwalker;

        //Spell List
        public static List<Spell> SpellList = new List<Spell>();

        //Spells
        public static Spell Q;
        public static Spell W;
        public static Spell E;
        public static Spell R;

        //Menu Config
        public static Menu Config;
        private static Obj_AI_Hero Player;
        


	    public static void main(String[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Player = ObjectManager.Player;
            if (Player.ChampionName != ChampionName) return;

            //Load Orbwalker
            Orbwalker = new Orbwalking.Orbwalker;
            Game.OnGameUpdate += Game_OnGameUpdate;    
            Game.PrintChat(ChampionName + " Loaded!");
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            Orbwalker.SetMovement(true);
            Vector3 pos = enemy.Position + Vector3.Normalize(enemy.Position - ObjectManager.Player.Position) * 650
            var enemy = SimpleTS.GetTarget(10000, SimpleTs.DamageType.Physical);

            if (enemy != null)
            {
                Orbwalker.Orbwalk(enemy, pos, 50);
            }
        }
    }
}
    
