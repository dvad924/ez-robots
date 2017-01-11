using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace Tutorial_49___WPF_Hosted {

  public partial class UserControl1 : UserControl {

    public UserControl1() {

      InitializeComponent();
    }

    private void simpleButtonClick(object sender, RoutedEventArgs e) {

      MeshGeometry3D triangleMesh = new MeshGeometry3D();

      Point3D point0 = new Point3D(0, 0, 0);
      Point3D point1 = new Point3D(5, 0, 0);
      Point3D point2 = new Point3D(0, 0, 5);
      triangleMesh.Positions.Add(point0);
      triangleMesh.Positions.Add(point1);
      triangleMesh.Positions.Add(point2);
      triangleMesh.TriangleIndices.Add(0);
      triangleMesh.TriangleIndices.Add(2);
      triangleMesh.TriangleIndices.Add(1);
      Vector3D normal = new Vector3D(0, 1, 0);
      triangleMesh.Normals.Add(normal);
      triangleMesh.Normals.Add(normal);
      triangleMesh.Normals.Add(normal);

      Material material = new DiffuseMaterial(new SolidColorBrush(Colors.DarkKhaki));
      GeometryModel3D triangleModel = new GeometryModel3D(triangleMesh, material);
      ModelVisual3D model = new ModelVisual3D();

      model.Content = triangleModel;

      this.mainViewport.Children.Add(model);
    }

    private Model3DGroup CreateTriangleModel(Point3D p0, Point3D p1, Point3D p2) {

      MeshGeometry3D mesh = new MeshGeometry3D();
      mesh.Positions.Add(p0);
      mesh.Positions.Add(p1);
      mesh.Positions.Add(p2);
      mesh.TriangleIndices.Add(0);
      mesh.TriangleIndices.Add(1);
      mesh.TriangleIndices.Add(2);
      Vector3D normal = CalculateNormal(p0, p1, p2);
      mesh.Normals.Add(normal);
      mesh.Normals.Add(normal);
      mesh.Normals.Add(normal);
      Material material = new DiffuseMaterial(new SolidColorBrush(Colors.DarkKhaki));
      GeometryModel3D model = new GeometryModel3D(mesh, material);
      Model3DGroup group = new Model3DGroup();
      group.Children.Add(model);

      return group;
    }

    private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2) {

      Vector3D v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
      Vector3D v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);

      return Vector3D.CrossProduct(v0, v1);
    }

    private void button1_Click(object sender, RoutedEventArgs e) {

      Model3DGroup cube = new Model3DGroup();
      Point3D p0 = new Point3D(0, 0, 0);
      Point3D p1 =new Point3D(5, 0, 0);
      Point3D p2 =new Point3D(5, 0, 5);
      Point3D p3 =new Point3D(0, 0, 5);
      Point3D p4 =new Point3D(0, 5, 0);
      Point3D p5 =new Point3D(5, 5, 0);
      Point3D p6 =new Point3D(5, 5, 5);
      Point3D p7 = new Point3D(0, 5, 5);

      //front side triangles
      cube.Children.Add(CreateTriangleModel(p3, p2, p6));
      cube.Children.Add(CreateTriangleModel(p3, p6, p7));

      //right side triangles
      cube.Children.Add(CreateTriangleModel(p2, p1, p5));
      cube.Children.Add(CreateTriangleModel(p2, p5, p6));

      //back side triangles
      cube.Children.Add(CreateTriangleModel(p1, p0, p4));
      cube.Children.Add(CreateTriangleModel(p1, p4, p5));

      //left side triangles
      cube.Children.Add(CreateTriangleModel(p0, p3, p7));
      cube.Children.Add(CreateTriangleModel(p0, p7, p4));

      //top side triangles
      cube.Children.Add(CreateTriangleModel(p7, p6, p5));
      cube.Children.Add(CreateTriangleModel(p7, p5, p4));

      //bottom side triangles
      cube.Children.Add(CreateTriangleModel(p2, p3, p0));
      cube.Children.Add(CreateTriangleModel(p2, p0, p1));

      ModelVisual3D model = new ModelVisual3D();

      model.Content = cube;

      this.mainViewport.Children.Add(model);

      SetCamera();
    }

    private void ClearViewport() {

      ModelVisual3D m;

      for (int i = mainViewport.Children.Count - 1; i >= 0; i--) {

        m = (ModelVisual3D)mainViewport.Children[i];
        if (m.Content is DirectionalLight == false)
          mainViewport.Children.Remove(m);
      }
    }

    private void SetCamera() {

      PerspectiveCamera camera = (PerspectiveCamera)mainViewport.Camera;

      Vector3D lookDirection = new Vector3D(
          Convert.ToDouble(lookAtXTextBox.Text),
          Convert.ToDouble(lookAtYTextBox.Text),
          Convert.ToDouble(lookAtZTextBox.Text)
      );

      Point3D position = new Point3D(
          Convert.ToDouble(cameraPositionXTextBox.Text),
          Convert.ToDouble(cameraPositionYTextBox.Text),
          Convert.ToDouble(cameraPositionZTextBox.Text)
      );

      camera.Position = position;

      camera.LookDirection = lookDirection;
    }

    public void DOIT(int val) {

      try {

        PerspectiveCamera camera = (PerspectiveCamera)mainViewport.Camera;

        Vector3D lookDirection = new Vector3D(
            Convert.ToDouble(lookAtXTextBox.Text),
            Convert.ToDouble(lookAtYTextBox.Text),
            Convert.ToDouble(lookAtZTextBox.Text)
        );

        Point3D position = new Point3D(
            Convert.ToDouble(cameraPositionXTextBox.Text),
            Convert.ToDouble(cameraPositionYTextBox.Text),
            Convert.ToDouble(cameraPositionZTextBox.Text)
        );

        camera.Position = position;

        camera.LookDirection = lookDirection;
      } catch {
      }
    }

    private void lookAtZTextBox_TextChanged(object sender, TextChangedEventArgs e) {

      DOIT(0);
    }
  }
}
