using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D.Triangle
{
    public class Triangle : FigureBase, ITriangle
    {
        public double A { get; private set; }
        public double B { get; private set; }

        /// <summary>
        /// C - большая сторона
        /// </summary>
        public double C { get; private set; }

        private readonly double sqrA;
        private readonly double sqrB;
        private readonly double sqrC;
        private readonly double sumAB;

        public Triangle(params Element[] elements) : base(elements) 
        {
            sqrA = fPw2(A);
            sqrB = fPw2(B);
            sumAB = sqrA + sqrB;
            sqrC = fPw2(C);
        }

        public bool Isosceles => (A == B) && (B != C);

        public bool Equilateral => (A == B && A == C && B == C);

        public bool versatile => (A != B && A != C && B != C);

        public AngledType OneFastMethod()
        {
            if(sqrC < sumAB)
                return AngledType.AcuteAngled;
            
            if (sqrC == sumAB)
                return AngledType.Rectangular;

            return AngledType.Obtuse;
        }

        public TriangleType GetTriangleType()
        {
            if (Isosceles) return TriangleType.Isosceles;
            if (Equilateral) return TriangleType.Equilateral;
            return TriangleType.Versatile;
        }

        protected override void Validated()
        {
            if (Elements == null || Elements.Length != 3)
                throw new TriangleArgumentException();

            A = Elements[0].Value;
            B = Elements[1].Value;
            C = Elements[2].Value;

            var max = B > A ? B : A;
            if (max > C)
            {
                var c = C;
                C = max;
                if (max == A) A = c;
                else if (max == B) B = c;
            }
        }
    }
}
