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
    /// Interaction logic for TokenPicker.xaml
    /// </summary>
    public partial class TokenPicker : UserControl {
        public static readonly DependencyProperty TokenClickProp = DependencyProperty.Register(
            nameof(TokenClick),
            typeof(ICommand),
            typeof(TokenPicker),
            new PropertyMetadata(null)
            );

        public ICommand TokenClick {
            get { return (ICommand)GetValue(TokenClickProp); }
            set { SetValue(TokenClickProp, value); }
        }

        public static readonly DependencyProperty PlayerStrProp = DependencyProperty.Register(
            nameof(PlayerStr),
            typeof(string),
            typeof(TokenPicker),
            new PropertyMetadata(null)
            );

        public string PlayerStr {
            get { return (string)GetValue(PlayerStrProp); }
            set { SetValue(PlayerStrProp, value); }
        }


        public TokenPicker() {
            InitializeComponent();
        }

        public void Grid_MouseUp(object sender, MouseButtonEventArgs e) {
            var point = Mouse.GetPosition(TokenGrid);

            int row = 0;
            int col = 0;
            double accumulatedHeight = 0.0;
            double accumulatedWidth = 0.0;

            // calc row mouse was over
            foreach (var rowDefinition in TokenGrid.RowDefinitions) {
                accumulatedHeight += rowDefinition.ActualHeight;
                if (accumulatedHeight >= point.Y)
                    break;
                row++;
            }

            // calc col mouse was over
            foreach (var columnDefinition in TokenGrid.ColumnDefinitions) {
                accumulatedWidth += columnDefinition.ActualWidth;
                if (accumulatedWidth >= point.X)
                    break;
                col++;
            }

            // row and col now correspond Grid's RowDefinition and ColumnDefinition mouse was over

            if (TokenClick != null)
                TokenClick.Execute(row * 4 + col);
        }
    }
}
