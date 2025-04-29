using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace CheaperLanternLining.Items
{
    internal class ItemLining : ItemMetalPlate  //Act like a metal plate
    {
        public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
        {
            //Interact like a metal plate if the target block is a lantern
            if (blockSel != null && byEntity.World.BlockAccessor.GetBlock(blockSel.Position) is BlockLantern)
            {
                base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);
                return;
            }
            //Do nothing otherwise
            handling = EnumHandHandling.PreventDefault;
        }
    } 
}