using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public  class GenerateWinForm : AbstractScreenGenerate
    {
        public override IComponent CreateComponent()
        {
            return new WinFormComponent();

        }

        public override IPage CreatePage()
        {
            return new WinForm();

        }
    }
}
