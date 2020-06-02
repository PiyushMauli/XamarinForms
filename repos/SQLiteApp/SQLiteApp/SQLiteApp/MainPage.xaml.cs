using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace SQLiteApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        private string _name;
        [MaxLength(255)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;
                _name = value;

                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    public partial class MainPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipe;
        public MainPage()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipe = new ObservableCollection<Recipe>(recipes);

            recipesListView.ItemsSource = _recipe;

            base.OnAppearing();
        }

        private async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Piyush " + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
            _recipe.Add(recipe);
        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            var recipe = _recipe[0];
            recipe.Name += " UPDATED";
            await _connection.UpdateAsync(recipe);
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var recipe = _recipe[0];
            await _connection.DeleteAsync(recipe);
            _recipe.Remove(recipe);
        }
    }
}
