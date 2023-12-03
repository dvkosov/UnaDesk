using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D.Triangle
{
    public enum AngledType
    {
        /// <summary>
        /// Остроугольный
        /// </summary>
        [Display(Name = "Остроугольный")] AcuteAngled
                   ,
        /// <summary>
        /// Прямоугольный
        /// </summary>
        [Display(Name = "Прямоугольный")] Rectangular
                   ,
        /// <summary>
        /// Тупоугольный
        /// </summary>
        [Display(Name = "Тупоугольный")] Obtuse

    }
}
