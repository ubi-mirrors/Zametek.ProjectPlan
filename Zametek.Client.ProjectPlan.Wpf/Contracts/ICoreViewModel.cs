﻿using System;
using System.Collections.Generic;
using Zametek.Common.Project;
using Zametek.Maths.Graphs;

namespace Zametek.Client.ProjectPlan.Wpf
{
    public interface ICoreViewModel
        : IPropertyChangedPubSubViewModel
    {
        DateTime ProjectStart
        {
            get;
            set;
        }

        bool ShowDates
        {
            get;
            set;
        }

        bool UseBusinessDays
        {
            get;
            set;
        }

        bool HasStaleOutputs
        {
            get;
            set;
        }

        bool HasCompilationErrors
        {
            get;
            set;
        }

        GraphCompilation<int, IDependentActivity<int>> GraphCompilation
        {
            get;
            set;
        }

        IList<ResourceDto> ResourceDtos
        {
            get;
        }

        double? DirectCost
        {
            get;
            set;
        }

        double? IndirectCost
        {
            get;
            set;
        }

        double? OtherCost
        {
            get;
            set;
        }

        double? TotalCost
        {
            get;
            set;
        }
    }
}