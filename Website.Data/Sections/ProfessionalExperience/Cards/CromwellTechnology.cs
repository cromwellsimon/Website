﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Data.Interfaces;
using Website.Shared.Cards.Dashboard;

namespace Website.Data.Sections.ProfessionalExperience;

public sealed class CromwellTechnology : ISectionCard
{
    public static string Name { get; } = "Cromwell Technology";

    public static DashboardCard Data { get; } = new()
    {
        Title = Name,
        Subtitle = "Full-stack C# Developer, 2022 - present",
        DetailCards = new()
        {

        }
    };
}
