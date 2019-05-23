using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace InjuryScript
{
    class Main : BaseScript
    {
        public Main()
        {
            Tick += ApplyEffectTick;
        }

        private async Task ApplyEffectTick()
        {
            await Delay(250);

            if (Game.PlayerPed.Health < 100)
            {
                if (Status.CanWalkingEffectsBeApplied())
                {
                    Debug.WriteLine("Applying Effects!");
                }
            }
        }
    }
}
