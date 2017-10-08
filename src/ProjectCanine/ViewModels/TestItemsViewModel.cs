using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using ProjectCanine.Core.Models;


namespace ProjectCanine
{
    public class TestItemsViewModel : ViewModelBase
    {
        public ObservableCollection<Test> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public TestItemsViewModel()
        {
            Title = "Select Test";
            Items = new ObservableCollection<Test>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();

                var tests = await DataStore.GetTestsAsync();
				var sections = await DataStore.GetSectionsAsync();
				var questions = await DataStore.GetQuestionsAsync();

                foreach (var test in tests)
                {
					test.Sections = new List<Section>();

					foreach (var section in sections.Where(s => s.Test == test.Id).OrderBy(s => s.SectionNumber))
					{
						section.Questions = new List<Question>();

						foreach (var question in questions.Where(q => q.Test == test.Id && q.Section == section.Id).OrderBy(q => q.QuestionNumber))
						{
							section.Questions.Add(question);
						}
						test.Sections.Add(section);
					}
                    Items.Add(test);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
