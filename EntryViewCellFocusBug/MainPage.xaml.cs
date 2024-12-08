namespace EntryViewCellFocusBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            Console.WriteLine("Entry_Focused");
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            Console.WriteLine("Entry_Unfocused");
        }
    }
}
