using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DoubleDetails
{
    public sealed partial class MainPage : Page
    {
        private IList<ParentClass> _parentList;
        public IList<ParentClass> ParentList = new List<ParentClass>()
        {
            new ParentClass()
            {
                Title = "First",
                Id = 'A',
                Children = new List<ChildClass>()
                {
                    new ChildClass(){Name = "A1",Id = 1},
                    new ChildClass(){Name = "A2",Id = 2},
                    new ChildClass(){Name = "A3",Id = 3},
                }
            }
        };

        public MainPage()
        {
            InitializeComponent();
            AddData();

        }

        public void AddData()
        {
            ParentList.Add(new ParentClass()
            {
                Title = "Second",
                Id = 'B',
                Children = new List<ChildClass>()
                {
                    new ChildClass(){Name = "B1",Id = 1},
                    new ChildClass(){Name = "B2",Id = 2},
                    new ChildClass(){Name = "B3",Id = 3},
                }
            });

            ParentList.Add(new ParentClass()
            {
                Title = "Third",
                Id = 'C',
                Children = new List<ChildClass>()
                {
                    new ChildClass(){Name = "C1",Id = 1},
                    new ChildClass(){Name = "C2",Id = 2},
                }
            });
        }

        private void ColorClick(object sender, RoutedEventArgs e)
        {
            listView.ItemTemplate = Resources["SecondDataTemplate"] as DataTemplate;
        }
    }

    public class ChildClass
    {
        public string Name;
        public int Id;
    }

    public class ParentClass
    {
        public string Title;
        public char Id;
        public List<ChildClass> Children;
    }
}
