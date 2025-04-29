using CheaperLanternLining.Items;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace CheaperLanternLining
{
    public class CheaperLanternLiningModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterItemClass(Mod.Info.ModID + ".itemlining", typeof(ItemLining));
        }

    }
}
