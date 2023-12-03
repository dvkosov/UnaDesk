using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D
{
    public class TriangleArgumentException : ArgumentException
    {
        public TriangleArgumentException() { }

        public TriangleArgumentException(string msg) : base(msg) { }
    }

}
