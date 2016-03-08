﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Storm.StardewValley.Accessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storm.StardewValley.Wrapper
{
    public class ShopMenu : ClickableMenu, Wrapper<ShopMenuAccessor>
    {
        private ShopMenuAccessor accessor;

        public ShopMenu(StaticContext parent, ShopMenuAccessor accessor) : 
            base(parent, accessor)
        {
            this.accessor = accessor;
        }

        public String DescriptionText
        {
            get { return accessor._GetDescriptionText(); }
            set { accessor._SetDescriptionText(value); }
        }

        public String HoverText
        {
            get { return accessor._GetHoverText(); }
            set { accessor._SetHoverText(value); }
        }

        public String BoldTitleText
        {
            get { return accessor._GetBoldTitleText(); }
            set { accessor._SetBoldTitleText(value); }
        }

        public InventoryMenu Inventory
        {
            get { return new InventoryMenu(Parent, accessor._GetInventory()); }
            set { accessor._SetInventory(value.Expose()); }
        }

        public Item HeldItem
        {
            get { return new Item(Parent, accessor._GetHeldItem()); }
            set { accessor._SetHeldItem(value.Expose()); }
        }

        public Item HoveredItem
        {
            get { return new Item(Parent, accessor._GetHoveredItem()); }
            set { accessor._SetHoveredItem(value.Expose()); }
        }

        public Texture2D Wallpapers
        {
            get { return accessor._GetWallpapers(); }
            set { accessor._SetWallpapers(value); }
        }

        public Texture2D Floors
        {
            get { return accessor._GetFloors(); }
            set { accessor._SetFloors(value); }
        }

        public int LastWallpaperFloorPrice
        {
            get { return accessor._GetLastWallpaperFloorPrice(); }
            set { accessor._SetLastWallpaperFloorPrice(value); }
        }

        public Rectangle ScrollBarRunner
        {
            get { return accessor._GetScrollBarRunner(); }
            set { accessor._SetScrollBarRunner(value); }
        }

        public float SellPercentage
        {
            get { return accessor._GetSellPercentage(); }
            set { accessor._SetSellPercentage(value); }
        }

        public System.Collections.IList Animations
        {
            get { return accessor._GetAnimations(); }
            set { accessor._SetAnimations(value); }
        }

        public int HoverPrice
        {
            get { return accessor._GetHoverPrice(); }
            set { accessor._SetHoverPrice(value); }
        }

        public int Currency
        {
            get { return accessor._GetCurrency(); }
            set { accessor._SetCurrency(value); }
        }

        public int CurrentItemIndex
        {
            get { return accessor._GetCurrentItemIndex(); }
            set { accessor._SetCurrentItemIndex(value); }
        }

        public ClickableTextureComponent UpArrow
        {
            get { return new ClickableTextureComponent(Parent, accessor._GetUpArrow()); }
            set { accessor._SetUpArrow(value.Expose()); }
        }

        public ClickableTextureComponent DownArrow
        {
            get { return new ClickableTextureComponent(Parent, accessor._GetDownArrow()); }
            set { accessor._SetDownArrow(value.Expose()); }
        }

        public ClickableTextureComponent ScrollBar
        {
            get { return new ClickableTextureComponent(Parent, accessor._GetScrollBar()); }
            set { accessor._SetScrollBar(value.Expose()); }
        }

        public NPC PortraitPerson
        {
            get { return new NPC(Parent, accessor._GetPortraitPerson()); }
            set { accessor._SetPortraitPerson(value.Expose()); }
        }

        public String PotraitPersonDialogue
        {
            get { return accessor._GetPotraitPersonDialogue(); }
            set { accessor._SetPotraitPersonDialogue(value); }
        }

        public bool Scrolling
        {
            get { return accessor._GetScrolling(); }
            set { accessor._SetScrolling(value); }
        }

        public new ShopMenuAccessor Expose() => accessor;
    }
}