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
using Viewer4WSCAD.Events;
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
            RulersVisibility = true;
            //MyEvents.RefreshSub.Subscribe(Refresh);
        }

        private void Refresh()
        {
            PMatrix neutralM = new PMatrix();
            MyCanvas.Children.Clear();
            if (Figures == null)
                return;
            foreach(var figure in Figures)
            {
                MyCanvas.Children.Add(figure));
            }



        }

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





        public bool RulersVisibility
        {
            get { return (bool)GetValue(RulersVisibilityProperty); }
            set { SetValue(RulersVisibilityProperty, value); }
        } 

        // Using a DependencyProperty as the backing store for RulersVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RulersVisibilityProperty =
            DependencyProperty.Register("RulersVisibility", typeof(bool), typeof(FiguresPresenter), new PropertyMetadata(default));

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ShowCmd = new DelegateCommand(Refresh);
        }
    }
}
