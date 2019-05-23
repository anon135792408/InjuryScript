using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace InjuryScript
{
    public class Status : BaseScript
    {
        private Status()
        {
        }

        public static bool CanWalkingEffectsBeApplied()
        {
            if (Game.PlayerPed.IsInVehicle())
            {
                return false;
            }
            else if (Game.PlayerPed.IsFalling)
            {
                return false;
            }
            else if (Game.PlayerPed.IsDead)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
