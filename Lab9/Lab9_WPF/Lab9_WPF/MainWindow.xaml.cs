using System;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Windows;


namespace Lab9_WPF
{
    public partial class MainWindow : Window
    {
        public static string Type { get; set; } = "";
        public static int PageSize { get; set; } = 5;
        public static int PageNumber { get; set; } = 1;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData() =>
            this.gridSnippet.ItemsSource = FetchSnippets(PageNumber, PageSize, Type).Batches;

        // Handle type change
        public void ChangeType(string type)
        {
            Type = type;
            LoadData();
        }

        private void Btn_Text_Click(object sender, RoutedEventArgs e) => ChangeType(Types.Text);

        private void Btn_Bash_Click(object sender, RoutedEventArgs e) => ChangeType(Types.Bash);

        private void Btn_Cpp_Click(object sender, RoutedEventArgs e) => ChangeType(Types.Cpp);

        private void Btn_CSharp_Click(object sender, RoutedEventArgs e) => ChangeType(Types.CSharp);

        private void Btn_Java_Click(object sender, RoutedEventArgs e) => ChangeType(Types.Java);

        private void Btn_CSS_Click(object sender, RoutedEventArgs e) => ChangeType(Types.CSS);

        private void Btn_HTML_Click(object sender, RoutedEventArgs e) => ChangeType(Types.HTML);

        private void Btn_JS_Click(object sender, RoutedEventArgs e) => ChangeType(Types.JavaScript);

        private void Btn_PHP_Click(object sender, RoutedEventArgs e) => ChangeType(Types.PHP);

        private void Btn_Python_Click(object sender, RoutedEventArgs e) => ChangeType(Types.Python);

        private void Btn_SQL_Click(object sender, RoutedEventArgs e) => ChangeType(Types.SQL);

        // Handle Page Size change
        public void Btn_LoadPageSizeData(object sender, RoutedEventArgs e)
        {
            PageSize = int.Parse(this.comboBoxPageSize.SelectedValue.ToString());
            LoadData();
        }


        // Handle Page Number change

        public static string FetchData(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                ContentType type = new ContentType(response.ContentType ?? "text/plain;charset=" + Encoding.UTF8.WebName);
                Encoding encoding = Encoding.GetEncoding(type.CharSet ?? Encoding.UTF8.WebName);

                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static PageReposne FetchSnippets(int pageNumber, int pageSize, string snippetsType)
        {
            string url = $"https://dirask.com/api/snippets?pageNumber={pageNumber}&pageSize={pageSize}&dataOrder=newest&dataGroup=batches&snippetsType={Uri.EscapeUriString(snippetsType)}";
            string data = FetchData(url);

            return JsonSerializer.Deserialize<PageReposne>(data);
        }

        private void Btn_One_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}