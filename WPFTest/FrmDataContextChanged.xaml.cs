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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for FrmDataContextChanged.xaml
    /// </summary>
    /// 

    public class Props
    {
        public List<string> ChangedProps { get; set; }
        public List<string> UnChangedProps { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsPresent { get; set; }
        public DateTime JoinDate { get; set; }
    }
    public partial class FrmDataContextChanged : Window
    {
        int index = 0;
        List<Student> students;
        List<string> difProperties;
        List<string> notDifProperties;
        public FrmDataContextChanged()
        {
            InitializeComponent();
            students = new List<Student>
            {
                new Student{Id=1, Name="Ahmed", Age=20, IsPresent=true, JoinDate=new DateTime(2011, 5, 20)},
                new Student{Id=2, Name="Maher", Age=23, IsPresent=false, JoinDate=new DateTime(2015, 12, 8)},
                new Student{Id=3, Name="Ahmed", Age=23, IsPresent=false, JoinDate=new DateTime(2017, 2, 1)},
                new Student{Id=4, Name="Ahmed", Age=29, IsPresent=true, JoinDate=new DateTime(2017, 2, 1)}
            };
            grdData.DataContext = students[0];
            ChangeCounter();
            grdData.DataContextChanged += GrdData_DataContextChanged;
        }

        private void GrdData_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var oldValue = e.OldValue;
            var newValue = e.NewValue;
            var props = CompareOldNew(oldValue, newValue);
            foreach (var propName in props.ChangedProps)
            {
                //List<object> changed = new List<object>();
                List<DependencyObject> changedDP = new List<DependencyObject>();
                changedDP = DependencyObjectHelper2.GetDependencyObjectsWithBindingToProperty(grdData, propName).ToList();
                //GetBindingSourcesRecursive(propName, grdData, changed);
                changedDP.ForEach((o) =>
                {
                    Control cntrl = ((Control)o);
                    cntrl.BorderBrush = Brushes.Red;
                    cntrl.BorderThickness = new Thickness(2);

                });
            }
            foreach (var propName in props.UnChangedProps)
            {
                List<object> notChanged = new List<object>();
                List<DependencyObject> unChangedDP = new List<DependencyObject>();
                unChangedDP = DependencyObjectHelper2.GetDependencyObjectsWithBindingToProperty(grdData, propName).ToList();

                //GetBindingSourcesRecursive(propName, this, notChanged);
                unChangedDP.ForEach((o) =>
                {
                    Control cntrl = ((Control)o);
                    cntrl.BorderBrush = Brushes.Black;
                    cntrl.BorderThickness = new Thickness(1);
                });

            }
        }

        private Props CompareOldNew(object oldValue, object newValue)
        {
            difProperties = new List<string>();
            notDifProperties = new List<string>();
            for (int i = 0; i < oldValue.GetType().GetProperties().Length; i++)
            {
                var valOld = oldValue.GetType().GetProperties()[i].GetValue(oldValue);
                var valNew = newValue.GetType().GetProperties()[i].GetValue(newValue);
                var prop = oldValue.GetType().GetProperties()[i].Name;
                if (!valOld.Equals(valNew))
                {
                    difProperties.Add(prop);
                }
                else
                    notDifProperties.Add(prop);

            }
            Props props = new Props
            {
                ChangedProps = difProperties,
                UnChangedProps = notDifProperties
            };
            return props;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (index + 1 == students.Count)
                return;
            else
            {
                index++;
                grdData.DataContext = students[index];
                ChangeCounter();
            }
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (index == 0)
                return;
            else
            {
                index--;
                grdData.DataContext = students[index];
                ChangeCounter();
            }

        }

        private void ChangeCounter()
        {
            lblEnd.Content = students.Count;
            lblStart.Content = index + 1;

        }

        private void GetBindingSourcesRecursive(string propertyName, DependencyObject root, List<object> sources)
        {
            List<BindingBase> bindings = DependencyObjectHelper.GetBindingObjects(root);
            Predicate<Binding> condition =
                (b) =>
                {
                    return (b.Path is PropertyPath)
                        && b.Path.Path == propertyName
                        && (!sources.Contains(root));
                };

            foreach (BindingBase bindingBase in bindings)
            {
                if (bindingBase is Binding)
                {
                    if (condition(bindingBase as Binding))
                        sources.Add(root);
                }
                else if (bindingBase is MultiBinding)
                {
                    MultiBinding mb = bindingBase as MultiBinding;
                    foreach (Binding b in mb.Bindings)
                    {
                        if (condition(bindingBase as Binding))
                            sources.Add(root);
                    }
                }
                else if (bindingBase is PriorityBinding)
                {
                    PriorityBinding pb = bindingBase as PriorityBinding;
                    foreach (Binding b in pb.Bindings)
                    {
                        if (condition(bindingBase as Binding))
                            sources.Add(root);
                    }
                }
            }

            int childrenCount = VisualTreeHelper.GetChildrenCount(root);
            if (childrenCount > 0)
            {
                for (int i = 0; i < childrenCount; i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(root, i);
                    GetBindingSourcesRecursive(propertyName, child, sources);
                }
            }
            }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
