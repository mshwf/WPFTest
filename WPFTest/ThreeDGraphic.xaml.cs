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
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
namespace WPFTest
{
    /// <summary>
    /// Interaction logic for ThreeDGraphic.xaml
    /// </summary>
    public partial class ThreeDGraphic : Window
    {
        double camPosX, camPosY, camPosZ, upDirX, upDirY, upDirZ, lookX, lookY, lookZ;
        public ThreeDGraphic()
        {
            InitializeComponent();
            camPosX = myPerspectiveCamera.Position.X;
            camPosY = myPerspectiveCamera.Position.Y;
            camPosZ = myPerspectiveCamera.Position.Z;

            upDirX = myPerspectiveCamera.UpDirection.X;
            upDirY = myPerspectiveCamera.UpDirection.Y;
            upDirZ = myPerspectiveCamera.UpDirection.Z;

            lookX = myPerspectiveCamera.LookDirection.X;
            lookY = myPerspectiveCamera.LookDirection.Y;
            lookZ = myPerspectiveCamera.LookDirection.Z;
        }

        private void viewport3D1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void viewport3D1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            //myPerspectiveCamera.Position = new Point3D(camPosX - (e.NewValue), camPosY, camPosZ);
            //myPerspectiveCamera.UpDirection = new Vector3D(upDirX + e.NewValue, upDirY, upDirZ);
            //myPerspectiveCamera.LookDirection = new Vector3D(lookX - e.NewValue, lookY, lookZ);
            myHorizontalRotation.Angle = e.NewValue * 36;
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //myPerspectiveCamera.Position = new Point3D(camPosX, camPosY - (e.NewValue), camPosZ);
            //myPerspectiveCamera.UpDirection = new Vector3D(upDirX, upDirY + e.NewValue, upDirZ);
            //myPerspectiveCamera.LookDirection = new Vector3D(lookX, lookY - e.NewValue, lookZ);
            myVerticalRotation.Angle = e.NewValue * 36;

        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //myPerspectiveCamera.Position = new Point3D(camPosX, camPosY, camPosZ - (e.NewValue));
            //myPerspectiveCamera.UpDirection = new Vector3D(upDirX, upDirY, upDirZ + e.NewValue);
            //myPerspectiveCamera.LookDirection = new Vector3D(lookX, lookY, lookZ - e.NewValue);
            myZRotation.Angle = e.NewValue * 36;

        }

        private void slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
