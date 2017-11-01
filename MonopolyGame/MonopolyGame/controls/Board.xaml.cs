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

namespace MonopolyGame.controls {
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : UserControl {
        /*public static readonly DependencyProperty PlayerPosProperty = DependencyProperty.Register(
            nameof(PlayerPos),
            typeof(int),
            typeof(Board),
            new PropertyMetadata("", OnPropertyChangedStatic)
            );

        public int PlayerPos
        {
            get { return (int)GetValue(PlayerPosProperty); }
            set { SetValue(PlayerPosProperty, value); }
        }

        private static void OnPropertyChangedStatic(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var instance = d as Board;

            // Defer to the instance method.
            instance?.OnPropertyChanged(d, e.Property);
        }

        private void OnPropertyChanged(DependencyObject d, DependencyProperty prop)
        {
            // animate ?
        }*/

        public Board() {
            InitializeComponent();
        }
    }
}
