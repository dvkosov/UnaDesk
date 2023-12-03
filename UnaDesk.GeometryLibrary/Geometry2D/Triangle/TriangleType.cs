using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D.Triangle
{
    public enum TriangleType
    {
        /// <summary>
        /// 1) если а = b, то треугольник равнобедренный
        /// </summary>
        [Display(Name = "Равнобедренный")]
        Isosceles,
        /// <summary>
        /// 2) если а = b = c, то треугольник равносторонний.
        /// </summary>
        [Display(Name = "Равносторонний")]
        Equilateral,
        /// <summary>
        /// 3) если а ≠ b ≠ с, то треугольник разносторонний.
        /// </summary>
        [Display(Name = "Разносторонний")]
        Versatile,
    }
}
