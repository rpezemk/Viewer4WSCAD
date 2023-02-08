using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Viewer4WSCAD.BusinessLogic;
using Viewer4WSCAD.Events;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.ViewModel
{
    internal class VM_Main : BindableBase
    {
        public VM_Main()
        {
            LoadFileCmd = new DelegateCommand(LoadFile);
            Figures = new ObservableCollection<AFigure>();
            //Figures.Add(new Circle() { Center = new System.Windows.Point(100, 100), Color = System.Windows.Media.Color.FromArgb(120, 0, 0, 0), IsFilled = true, Radius = 50 });
        }

        private void Refresh()
        {
            MyEvents.RefreshSub.Publish();
        }

        private double scaleLog;

        public double ScaleLog
        {
            get { return scaleLog; }
            set { SetProperty(ref scaleLog, value); ScaleLin = MathHelpers.Log2Lin(scaleLog); }
        }

        private double scaleLin;

        public double ScaleLin
        {
            get { return scaleLin; }
            set { SetProperty(ref scaleLin, value); }
        }


        private void LoadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml";
            if (dialog.ShowDialog() == false)
                return;
            JsonDeserializer deserializer = new JsonDeserializer();

            var json = File.ReadAllText(dialog.FileName);
            var roots = deserializer.GetFigures(json);

            Figures.Clear();
            foreach(var root in roots)
            {
                var fig = GeometryHelper.GetFigure(root);
                Figures.Add(fig);
            }

        }

        private DelegateCommand loadFileCmd;
        private DelegateCommand showCmd;
        private ObservableCollection<AFigure> figures;

        public DelegateCommand LoadFileCmd { get => loadFileCmd; set => SetProperty(ref loadFileCmd, value); }
        public DelegateCommand ShowCmd { get => showCmd; set => SetProperty(ref showCmd, value); }
        public ObservableCollection<AFigure> Figures { get => figures; set => SetProperty(ref figures, value); }

    }





}
