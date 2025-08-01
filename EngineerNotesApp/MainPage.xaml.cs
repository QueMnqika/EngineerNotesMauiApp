namespace EngineerNotesApp
{
    public partial class MainPage : ContentPage
    {
        string _filename = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");


        public MainPage()
        {
            InitializeComponent();
            checkFileExists();
        }

        public void checkFileExists()
        {
            if (File.Exists(_filename))
            {
                editor.Text = File.ReadAllText(_filename);
            }

        }
    }
}
