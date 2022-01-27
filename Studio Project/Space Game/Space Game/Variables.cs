using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Drawing.Text;
using System.Drawing;

namespace Space_Game
{
    class Variables
    {
        public static string ShipColor, Class, Gender, Orientation, SaveVariables, CurrentForm, EnemyName, BattleOutcome = null, PlanetImage, Special, PlanetCombatBG, ItemFound, MessageBoxOutput;

        public static int ShipNewY, ShipNewX, ShipOldY, ShipOldX, Stage = 1, PlayerNewY, PlayerNewX, PlayerOldY, PlayerOldX, PlayerDamage, EnemyDamage, PlayerHP, EnemyHP, PlayerDodgeChance, EnemyDodgeChance, BattleStatus = 1;

        public static string[] ResourceNameShip = new string[8];

        public static string[] ResourceNameCharacter = new string[13];

        public static Bitmap[] Explosion = new Bitmap[7];

        public static Image EnemyIcon;

        public static bool SoundOn = true, Pause = false, PlanetVisible = false, OnPlanet = false, GameWasLoaded = false, AsteroidsVisible = false, Cheated = false, ClassChosen = false, isBoss, CheatsEnabled;

        public static SoundPlayer Music = new SoundPlayer();

        public static PrivateFontCollection CustomFont = new PrivateFontCollection();
    }
}
