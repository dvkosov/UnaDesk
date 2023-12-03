using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary
{
    public abstract class FigureBase
    {
        public Element[] Elements { get; private set; }

        public Func<double, double> fPw2 = (value)=> Math.Pow(value, 2);

        public FigureBase(params Element[] elements)
        {
            Elements = elements;
            Validated();
        }

        protected abstract void Validated();
    }
}
