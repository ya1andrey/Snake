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

namespace Snake
{
    
    public partial class MainWindow : Window
    {
        private readonly Dictionary<GridValue, ImageSource> gridValueToImages = new Dictionary<GridValue, ImageSource>()
        {
            { GridValue.Empty, Images.cell },
            { GridValue.Snake, Images.body },
            { GridValue.Food, Images.food },
        };

        private readonly int rows = 15, cols = 15;
        private readonly Image[,] gridImages;
        private GameState gameState;

        public MainWindow()
        {
            InitializeComponent();
            gridImages = SetupGrid();
            gameState = new GameState(rows, cols);
        }

        



        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.cell
                    };

                    images[r, c] = image;
                    GameGrid.Children.Add(image);

                }
            }
            return images;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Draw();
        }
        private void Window_KeyDown(object sender, RoutedEventArgs e)
        {
            
        }
        private void Draw()
        {
            DrawGrid();
        }

        private void DrawGrid()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    GridValue gridVal = gameState.Grid[r, c];
                    gridImages[r, c].Source = gridValueToImages[gridVal];
                }
            }
        }
    }
}
