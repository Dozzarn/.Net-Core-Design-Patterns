using System;

namespace AbstractFactory
{
    public abstract class AbstractScreenGenerate
    {
        public abstract IPage CreatePage();

        public abstract IComponent CreateComponent();
    }
}
