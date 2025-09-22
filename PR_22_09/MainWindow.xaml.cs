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
using Construction;

namespace PR_22_09
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Builder builder;
        public MainWindow()
        {
            InitializeComponent();
            builder = new Builder();
        }
        private void CalculateWallpaper_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(txtRoomWidth.Text);
                double roomLength = double.Parse(txtRoomLength.Text);
                double roomHeight = double.Parse(txtRoomHeight.Text);
                double windowHeight = double.Parse(txtWindowHeight.Text);
                double windowWidth = double.Parse(txtWindowWidth.Text);
                double doorHeight = double.Parse(txtDoorHeight.Text);
                double doorWidth = double.Parse(txtDoorWidth.Text);
                double rollWidth = double.Parse(cmbRollWidth.Text);

                int rolls = builder.PasteWallpaper(roomWidth, roomLength, roomHeight,
                                                 windowHeight, windowWidth,
                                                 doorHeight, doorWidth,
                                                 rollWidth);

                lblWallpaperResult.Text = $"Необходимо рулонов: {rolls}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void CalculateLinoleum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(txtLinRoomWidth.Text);
                double roomLength = double.Parse(txtLinRoomLength.Text);
                double linoleumWidth = double.Parse(cmbLinoleumWidth.Text);

                double meters = builder.LayLinoleum(roomWidth, roomLength, linoleumWidth);

                lblLinoleumResult.Text = $"Необходимо метров: {meters:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void CalculatePaint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(txtPaintRoomWidth.Text);
                double roomLength = double.Parse(txtPaintRoomLength.Text);
                double consumption = double.Parse(txtPaintConsumption.Text);
                double canVolume = double.Parse(txtCanVolume.Text);

                int cans = builder.CeilingPainting(roomWidth, roomLength, consumption, canVolume);

                lblPaintResult.Text = $"Необходимо банок: {cans}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
