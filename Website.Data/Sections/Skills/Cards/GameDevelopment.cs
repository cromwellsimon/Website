﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Data.Interfaces;
using Website.Shared.Cards.Dashboard;
using Website.Shared.Cards.Detail;

namespace Website.Data.Sections.Skills;

public sealed class GameDevelopment : ISectionCard
{
    public static string Name { get; } = "Game Development";

    public const string Unreal = nameof(Unreal);
    public const string Unity = nameof(Unity);
    public const string Godot = nameof(Godot);
    public const string Stride = nameof(Stride);
    public const string Blender = nameof(Blender);

    public static DashboardCard Data { get; } = new(Name)
    {
        DetailCards = new()
        {
            new TitleContentCard() { Title = Unreal },
            new TitleContentCard() { Title = Unity },
            new TitleContentCard() { Title = Godot },
            new TitleContentCard() { Title = Stride },
            new TitleContentCard() { Title = Blender },
        }
    };
}