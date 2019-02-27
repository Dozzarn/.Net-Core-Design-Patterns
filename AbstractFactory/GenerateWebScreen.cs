using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class GenerateWebScreen : AbstractScreenGenerate
    {
        public override IComponent CreateComponent()
        {
            return new WebComponent();
        }

        public override IPage CreatePage()
        {
            return new WebPage();
        }
    }
}
