using HunterPie.Core;
using HunterPie.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterPie.Plugins
{
    public class AutoUpdateTest : IPlugin
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Game Context { get; set; }

        public void Initialize(Game context)
        {
            Name = "AutoUpdateTest";
            Description = "Woah";

            Context = context;

            this.Log("Hello world!");
        }

        public void Unload()
        {
            
        }
    }
}
