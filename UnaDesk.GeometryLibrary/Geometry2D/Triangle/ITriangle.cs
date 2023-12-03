using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D.Triangle
{
    interface ITriangle : IGeometry2D
    {
        double A { get; }
        double B { get; }
        /// <summary>
        /// C - большая сторона
        /// </summary>
        double C { get; }

        /// <summary>
        /// Равнобедренный
        /// </summary>
        public bool Isosceles { get; }

        /// <summary>
        /// Равносторонний
        /// </summary>
        public bool Equilateral { get; }

        /// <summary>
        /// Разносторонний
        /// </summary>
        public bool versatile { get; }
       
        /// <summary>
        /// Тип треугольника
        /// </summary>
        /// <returns></returns>
        TriangleType GetTriangleType();

        /// <summary>
        /// Метод, который по трем сторонам треугольника будет определять, является треугольник остроугольным, прямоугольным или тупоугольным.
        /// </summary>
        /// <returns></returns>
        AngledType OneFastMethod();
    }
}
