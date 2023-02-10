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
using System.Windows;
using System.Xml.Linq;
using Viewer4WSCAD.Deserializers;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.ViewModel
{
    public class VM_Main : BindableBase
    {
        public VM_Main()
        {
            LoadFileCmd = new DelegateCommand(LoadFile);
            LoadMyExampleCmd = new DelegateCommand(LoadMyExample);
            LoadWSCADExampleCmd = new DelegateCommand(LoadWSCADExample);
            LoadMyUnimplementedExampleCmd = new DelegateCommand(LoadUnimplemented);
            Figures = new ObservableCollection<AFigure>();
        }

        private void LoadUnimplemented()
        {
            var json = Examples.UnimplementedFigureExample;
            Figures = new ObservableCollection<AFigure>(GeometryHelpers.GetFigures(json, new JsonDeserializer()));
            ShowCmd.Execute();
        }

        private void LoadWSCADExample()
        {
            var json = Examples.WSCADExample;
            Figures = new ObservableCollection<AFigure>(GeometryHelpers.GetFigures(json, new JsonDeserializer()));
            ShowCmd.Execute();
        }

        private void LoadMyExample()
        {
            var json = Examples.MyExample;
            Figures = new ObservableCollection<AFigure>(GeometryHelpers.GetFigures(json, new JsonDeserializer()));
            ShowCmd.Execute();
        }

        private void LoadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml";
            if (dialog.ShowDialog() == false)
                return;
            IDeserializer deserializer;
            if (Path.GetExtension(dialog.FileName) == ".json")
                deserializer = new JsonDeserializer();
            else if(Path.GetExtension(dialog.FileName) == ".xml")
                deserializer = new XmlDeserializer();
            else
            {
                MessageBox.Show("nieprawidłose rozszerzenie pliku!");
                return;
            }
            var fileData = File.ReadAllText(dialog.FileName);
            Figures = new ObservableCollection<AFigure>(GeometryHelpers.GetFigures(fileData, deserializer));
            ShowCmd.Execute();//bound in xaml!
        }

        private DelegateCommand loadWSCADExampleCmd;
        private DelegateCommand loadMyExampleCmd;
        private DelegateCommand loadUnimplementedMyExampleCmd;
        private DelegateCommand loadFileCmd;
        private DelegateCommand showCmd;
        private ObservableCollection<AFigure> figures;
        public DelegateCommand LoadFileCmd { get => loadFileCmd; set => SetProperty(ref loadFileCmd, value); }
        public DelegateCommand LoadWSCADExampleCmd { get => loadWSCADExampleCmd; set => SetProperty(ref loadWSCADExampleCmd, value); }
        public DelegateCommand LoadMyExampleCmd { get => loadMyExampleCmd; set => SetProperty(ref loadMyExampleCmd, value); }
        public DelegateCommand LoadMyUnimplementedExampleCmd { get => loadUnimplementedMyExampleCmd; set => SetProperty(ref loadUnimplementedMyExampleCmd, value); }
        public DelegateCommand ShowCmd { get => showCmd; set => SetProperty(ref showCmd, value); }
        public ObservableCollection<AFigure> Figures { get => figures; set => SetProperty(ref figures, value); }
    }





}
