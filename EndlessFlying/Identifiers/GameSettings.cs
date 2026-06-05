using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Identifiers
{
    public class GameSettings
    {

        public const float Plane_Speed = 250F;
        public const float Plane1_Base_Scale = 1.35F;
        public const float Plane2_Base_Scale = 1.25F;
        public const int Plane_Min_Spawn = 1500;
        public const int Plane_Max_Spawn = 5500;
        public const float Plane_VerticalDrift = 20F;

        public const int House_Speed = 1;
        public const float House_Base_Scale = 1.30F;
        public const int House_Min_Spawn = 1000;
        public const int House_Max_Spawn = 4000;

        public const int Tree_Speed = 1;
        public const float Tree_Base_Scale = 1.30F;
        public const int Tree_Min_Spawn = 750;
        public const int Tree_Max_Spawn = 3500;

        public const int Player_Speed = 5;
        public const float Player_Scale = 1.30F;
        public const float Player_BottomMargin = 100F;

        public const int Background_Speed = 1;
        public const float Background_Scale = 0.60F;

        public const int ScreenHeight = 800;
        public const int ScreenWidth = 470;

    }
}

