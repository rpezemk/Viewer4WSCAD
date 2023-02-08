using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PMatrix = Viewer4WSCAD.Helpers.PMatrix;
using Color = System.Windows.Media.Color;
using Viewer4WSCAD.BusinessLogic;

namespace Viewer4WSCAD.Types.Geometry
{
    public abstract class AFigure
    {
        public AFigure(Root root) 
        {
            var color = root.color.Split(";").Select(s => byte.Parse(s)).ToList();
            Color = new Color() { A = color[0], R = color[1], G = color[2], B = color[3] };
        }
        public Color Color { get; set; }

    }
}
