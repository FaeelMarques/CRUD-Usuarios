﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Model.Presentation
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
