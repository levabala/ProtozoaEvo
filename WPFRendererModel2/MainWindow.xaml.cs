﻿using Model;
using System;
using System.Collections.Generic;
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

namespace WPFRendererModel2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            Random rnd = new Random();
            World world = new World();
            WorldRenderer worldRenderer = new WorldRenderer(world);
            WorldElement worldElement = new WorldElement(mainCanvas);
            WorldController worldController = new WorldController(world);

            worldElement.setWorldRenderer(worldRenderer);
            mainCanvas.Children.Add(worldElement);

            worldController.addFertilitySource();
            worldController.addFertilitySource();
            worldController.addNewZoa();
            worldController.addNewZoa();
            worldController.addNewZoa();

            worldController.Resume();
        }
    }
}
