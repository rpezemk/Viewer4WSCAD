using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Controls
{
    /// <summary>
    /// Interaction logic for FiguresPresenter.xaml
    /// </summary>
    public partial class FiguresPresenter : UserControl
    {
        public FiguresPresenter()
        {
            InitializeComponent();
            if (Figures == null)
                Figures = new ObservableCollection<AFigure>();
            Figures.CollectionChanged += Figures_CollectionChanged;
        }

        private void Figures_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            if (Figures == null)
                return;
            var bounds = GeometryHelpers.GetBounds(Figures.ToList());
            LeftMargin = Math.Max(0, -bounds[0]);
            BottomMargin = Math.Max(0, -bounds[3]);
        }




        public double LeftMargin
        {
            get { return (double)GetValue(LeftMarginProperty); }
            set { SetValue(LeftMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftMarginProperty =
            DependencyProperty.Register("LeftMargin", typeof(double), typeof(FiguresPresenter), new PropertyMetadata(default));



        public double BottomMargin
        {
            get { return (double)GetValue(BottomMarginProperty); }
            set { SetValue(BottomMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BottomMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottomMarginProperty =
            DependencyProperty.Register("BottomMargin", typeof(double), typeof(FiguresPresenter), new PropertyMetadata(default));






        public Point OriginOffset
        {
            get { return (Point)GetValue(OriginOffsetProperty); }
            set { SetValue(OriginOffsetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OriginOffset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OriginOffsetProperty =
            DependencyProperty.Register("OriginOffset", typeof(Point), typeof(FiguresPresenter), new PropertyMetadata(default));




        public double Scale
        {
            get { return (double)GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Scale.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register("Scale", typeof(double), typeof(FiguresPresenter), new PropertyMetadata(default));


        public DelegateCommand ShowCmd
        {
            get { return (DelegateCommand)GetValue(ShowCmdProperty); }
            set { SetValue(ShowCmdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowCmd.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowCmdProperty =
            DependencyProperty.Register("ShowCmd", typeof(DelegateCommand), typeof(FiguresPresenter), new PropertyMetadata(abc));

        private static void abc(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = "test";
        }

        public ObservableCollection<AFigure> Figures
        {
            get { return (ObservableCollection<AFigure> )GetValue(FiguresProperty); }
            set { SetValue(FiguresProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Figures.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FiguresProperty =
            DependencyProperty.Register("Figures", typeof(ObservableCollection<AFigure> ), typeof(FiguresPresenter), new PropertyMetadata(default));


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ShowCmd = new DelegateCommand(Refresh);
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
