using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

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

            float health = Game.PlayerPed.Health;

            if (health <= 60 && health > 30)
            {
                if (Status.CanWalkingEffectsBeApplied())
                {
                    if (!HasAnimSetLoaded("move_m@injured"))
                        RequestAnimSet("move_m@injured");

                    SetPedMovementClipset(Game.PlayerPed.Handle, "move_m@injured", 1f);
                }
            }
            else if (health < 31)
            {
                if (Status.CanWalkingEffectsBeApplied())
                {
                    if (!HasAnimSetLoaded("move_m@drunk@verydrunk"))
                        RequestAnimSet("move_m@drunk@verydrunk");

                    SetPedMovementClipset(Game.PlayerPed.Handle, "move_m@drunk@verydrunk", 1f);
                }
            }
            else
            {
                ResetPedMovementClipset(Game.PlayerPed.Handle, 1f);
                ResetPedWeaponMovementClipset(Game.PlayerPed.Handle);
                ResetPedStrafeClipset(Game.PlayerPed.Handle);
            }
        }
    }
}
