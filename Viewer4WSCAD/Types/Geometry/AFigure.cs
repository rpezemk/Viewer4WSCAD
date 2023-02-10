using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Color = System.Windows.Media.Color;
using Prism.Mvvm;

namespace Viewer4WSCAD.Types.Geometry
{
    public abstract class AFigure : BindableBase
    {
        private Color color;

        public AFigure(Root root)
        {
            var color = root.color.Split(";").Select(s => byte.Parse(s)).ToList();
            Color = new Color() { A = color[0], R = color[1], G = color[2], B = color[3] };
        }
        public Color Color { get => color; set => SetProperty(ref color, value); }
        public abstract List<double> Boundaries { get; }
    }
}
