using Smod2;
using Smod2.Attributes;
using scp4aiur;
namespace Finalboss096
{
    [PluginDetails(
        author = "Albertinchu ",
        name = "Finalboss096",
        description = "un 096 con 40000 de vida, muchos jugadores...",
        id = "albertinchu.gamemode.Finalboss096",
        version = "1.0.0",
        SmodMajor = 3,
        SmodMinor = 0,
        SmodRevision = 0
        )]
    public class Finalboss096 : Plugin
    {

        public override void OnDisable()
        {
            this.Info("Finalboss096 - Desactivado");
        }

        public override void OnEnable()
        {
            Info("Finalboss096 - activado.");
        }

        public override void Register()
        {
            GamemodeManager.Manager.RegisterMode(this);
            Timing.Init(this);
            this.AddEventHandlers(new PlayersEvents(this));

        }
        public void RefreshConfig()
        {


        }
    }

}

