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

namespace Ex1026_XamlandLayout_Study
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Cursor = Cursors.Wait;
        //    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

        //    AnswerGenerator generator = new AnswerGenerator();
        //    txtAnswer.Text = generator.GetRandomAnswer(txtQusetion.Text);
        //    this.Cursor = null;
        //}
    }
}
