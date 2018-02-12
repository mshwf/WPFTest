using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup.Primitives;

namespace WPFTest
{
    public static class DependencyObjectHelper
    {
        public static List<BindingBase> GetBindingObjects(Object element)
        {
            List<BindingBase> bindings = new List<BindingBase>();
            List<DependencyProperty> dpList = new List<DependencyProperty>();
            dpList.AddRange(GetDependencyProperties(element));
            dpList.AddRange(GetAttachedProperties(element));

            foreach (DependencyProperty dp in dpList)
            {
                BindingBase b = BindingOperations.GetBindingBase(element as DependencyObject, dp);
                if (b != null)
                {
                    bindings.Add(b);
                }
            }

            return bindings;
        }

        public static List<DependencyProperty> GetDependencyProperties(Object element)
        {
            List<DependencyProperty> properties = new List<DependencyProperty>();
            MarkupObject markupObject = MarkupWriter.GetMarkupObjectFor(element);
            if (markupObject != null)
            {
                foreach (MarkupProperty mp in markupObject.Properties)
                {
                    if (mp.DependencyProperty != null)
                    {
                        properties.Add(mp.DependencyProperty);
                    }
                }
            }

            return properties;
        }

        public static List<DependencyProperty> GetAttachedProperties(Object element)
        {
            List<DependencyProperty> attachedProperties = new List<DependencyProperty>();
            MarkupObject markupObject = MarkupWriter.GetMarkupObjectFor(element);
            if (markupObject != null)
            {
                foreach (MarkupProperty mp in markupObject.Properties)
                {
                    if (mp.IsAttached)
                    {
                        attachedProperties.Add(mp.DependencyProperty);
                    }
                }
            }

            return attachedProperties;
        }
    }
    public static class DependencyObjectHelper2
    {
        /// <summary>
        /// Gets all dependency objects which has binding to specific property
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static IList<DependencyObject> GetDependencyObjectsWithBindingToProperty(DependencyObject dependencyObject, string propertyName)
        {
            var list = new List<DependencyObject>();
            GetDependencyObjectsWithBindingToPropertyRecursive(propertyName, dependencyObject, list);

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="dependencyObject"></param>
        /// <param name="sources"></param>
        /// <remarks>
        /// Based on ASanch answer on http://stackoverflow.com/questions/3959421/wpf-find-control-that-binds-to-specific-property
        /// </remarks>>
        private static void GetDependencyObjectsWithBindingToPropertyRecursive(string propertyName, DependencyObject dependencyObject, ICollection<DependencyObject> sources)
        {
            var dependencyProperties = new List<DependencyProperty>();
            dependencyProperties.AddRange(MarkupWriter.GetMarkupObjectFor(dependencyObject).Properties.Where(x => x.DependencyProperty != null).Select(x => x.DependencyProperty).ToList());
            dependencyProperties.AddRange(
                MarkupWriter.GetMarkupObjectFor(dependencyObject).Properties.Where(x => x.IsAttached && x.DependencyProperty != null).Select(x => x.DependencyProperty).ToList());

            var bindings = dependencyProperties.Select(x => BindingOperations.GetBindingBase(dependencyObject, x)).Where(x => x != null).ToList();

            Predicate<Binding> condition = binding => binding != null && binding.Path.Path == propertyName && !sources.Contains(dependencyObject);

            foreach (var bindingBase in bindings)
            {
                if (bindingBase is Binding)
                {
                    if (condition(bindingBase as Binding))
                        sources.Add(dependencyObject);
                }
                else if (bindingBase is MultiBinding)
                {
                    if (((MultiBinding)bindingBase).Bindings.Any(bindingBase2 => condition(bindingBase2 as Binding)))
                    {
                        sources.Add(dependencyObject);
                    }
                }
                else if (bindingBase is PriorityBinding)
                {
                    if (((PriorityBinding)bindingBase).Bindings.Any(bindingBase2 => condition(bindingBase2 as Binding)))
                    {
                        sources.Add(dependencyObject);
                    }
                }
            }

            var children = LogicalTreeHelper.GetChildren(dependencyObject).OfType<DependencyObject>().ToList();
            if (children.Count == 0)
                return;

            foreach (var child in children)
            {
                GetDependencyObjectsWithBindingToPropertyRecursive(propertyName, child, sources);
            }
        }
    }
}
