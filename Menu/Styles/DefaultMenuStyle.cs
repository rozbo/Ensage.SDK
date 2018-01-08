﻿// <copyright file="DefaultMenuStyle.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Menu.Styles
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.Menu.Styles.Elements;
    using Ensage.SDK.Renderer;

    using SharpDX;

    [Export]
    [Export(typeof(IMenuStyle))]
    public class DefaultMenuStyle : IMenuStyle
    {
        [ImportingConstructor]
        public DefaultMenuStyle([Import] IRendererManager renderer)
        {
            renderer.TextureManager.LoadFromResource(this.Menu, @"MenuStyle.default_transparent.menubg1.png");
            renderer.TextureManager.LoadFromResource(this.TitleBar, @"MenuStyle.default_transparent.itembg1.png");
            renderer.TextureManager.LoadFromResource(this.Item, @"MenuStyle.default_transparent.itembg1.png");
            renderer.TextureManager.LoadFromResource(this.ArrowLeft, @"MenuStyle.default_transparent.arrowleft.png");
            renderer.TextureManager.LoadFromResource(this.ArrowLeftHover, @"MenuStyle.default_transparent.arrowlefthover.png");
            renderer.TextureManager.LoadFromResource(this.ArrowRight, @"MenuStyle.default_transparent.arrowright.png");
            renderer.TextureManager.LoadFromResource(this.ArrowRightHover, @"MenuStyle.default_transparent.arrowrighthover.png");
            renderer.TextureManager.LoadFromResource(this.Checked, @"MenuStyle.default_transparent.circleshadow.png");
            renderer.TextureManager.LoadFromResource(this.Unchecked, @"MenuStyle.default_transparent.circleshadowgray.png");
            renderer.TextureManager.LoadFromResource(this.Slider, @"MenuStyle.default_transparent.sliderbgon.png");
        }

        public string ArrowLeft { get; } = "menuStyle/default/left";

        public string ArrowLeftHover { get; } = "menuStyle/default/leftHover";

        public string ArrowRight { get; } = "menuStyle/default/right";

        public string ArrowRightHover { get; } = "menuStyle/default/rightHover";

        public string Checked { get; } = "menuStyle/default/checked";

        public string Item { get; } = "menuStyle/default/item";

        public string Menu { get; } = "menuStyle/default/menu";

        public string Name { get; } = "Default";

        public string Slider { get; } = "menuStyle/default/slider";

        public StyleConfig StyleConfig { get; } = new StyleConfig();

        public string TitleBar { get; } = "menuStyle/default/titlebar";

        public string Unchecked { get; } = "menuStyle/default/unchecked";

        public override string ToString()
        {
            return this.Name;
        }
    }
}