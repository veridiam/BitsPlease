﻿using System;
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
using BitsPlease;

namespace Sequencer
{
    /// <summary>
    /// Interaction logic for SequencerMain.xaml
    /// </summary>
    public partial class SequencerMain : Window
    {
        public SequencerMain()
        {
            InitializeComponent();
        }

    private void OnMessageLogged(object sender, Unosquare.FFME.MediaLogMessagEventArgs e)
    {
      Console.WriteLine(e.Message);
    }
  }
}
