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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> Emoji = new List<string>()
            {
                "a","a",
                "b","b",
                "c","c",
                "d","d",
                "e","e",
                "f","f",
                "g","g",
                "h","h",
              

            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(Emoji.Count);
                string nextEmoji = Emoji[index];
                textBlock.Text = nextEmoji;
                Emoji.RemoveAt(index);  


            }


        }
    }
}
