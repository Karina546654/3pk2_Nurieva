using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PZ_7_htlfrnjh
{
    
    public partial class MainWindow : Window
    {

        public bool isShowListFiles = false;
        public string link = @"C:\Users\rinaa\OneDrive\Документы\new";
        bool isBold;
        bool isUnderline;
        bool isItalic;
        public string semple="Образец";
        public MainWindow()
        {
            InitializeComponent();

            if (isShowListFiles == false)
            {
                DirectoryInfo dir = new DirectoryInfo(link);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    listik.Items.Add(fi.ToString());
                }
                isShowListFiles = true;
            }

        }

        private void Button_Click_save(object sender, RoutedEventArgs e)
        {
           
            string r = $"{listik.SelectedItem}";
            StreamWriter streamWriter = new StreamWriter(link + r);
            streamWriter.WriteLine(txtEditor.Text);
            streamWriter.Close();

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void Button_Click_new(object sender, RoutedEventArgs e)
        {

            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
            {
                File.Create(link + $"{createFileWindow.FileName}" + ".txt");
                listik.Items.Add($"{createFileWindow.FileName}" + ".txt");
            }
            createFileWindow.Close();

        }

        private void Open_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текс (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251));
                txtEditor.Text = reader.ReadToEnd();
                reader.Close();
                return;
            }
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
            string r = $"{listik.SelectedItem}";
            if (File.Exists(link + r))
            {
                File.Delete(link + r);
            }
            listik.Items.RemoveAt(listik.SelectedIndex);
        }

        private void listik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string r = $"{listik.SelectedItem}";
            if (File.Exists(link + r))
            {
                txtEditor.Clear();
                FileStream open = new FileStream(link + $"{r}", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader file = new StreamReader(open);
                txtEditor.AppendText(file.ReadToEnd());
                file.Close();
            }

            if (isShowListFiles == false)
            {
                DirectoryInfo dir = new DirectoryInfo(link);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    listik.Items.Add(fi.ToString());
                }
                isShowListFiles = true;
            }
           

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Не сохранено";
        }

        private void Button_kursiv_Click(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                txtEditor.FontStyle = FontStyles.Italic;
            else
                txtEditor.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }

        private void Button_bold_Click_1(object sender, RoutedEventArgs e)
        {

            if (!isBold)
                txtEditor.FontWeight = FontWeights.Bold;
            else
                txtEditor.FontWeight = FontWeights.Normal;
            isBold = !isBold;

        }

        private void Button_Delet_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Clear();
        }

        private void Button_Click_podcher(object sender, RoutedEventArgs e)
        {
            if (this.isUnderline)
            {
                this.txtEditor.TextDecorations.Add(TextDecorations.Underline);
            }
            else
            {
                foreach (var item in TextDecorations.Underline)
                {
                    this.txtEditor.TextDecorations.Remove(item);
                }
            }
            isUnderline = !isUnderline;
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEditor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void DataTime_razmer(object sender, KeyEventArgs e)
        {
            FileInfo file1 = new FileInfo(link + $"{listik.SelectedItem}");
            DataTime.Text = $"{file1.CreationTime}   {file1.Length / 1024} Кб";
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = semple;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            semple = txtEditor.Text;
        }

        private void autors_click(object sender, RoutedEventArgs e)
        {
            Autors autors = new Autors();
            autors.Show();
        }

        private void program_click(object sender, RoutedEventArgs e)
        {
            Program program1 = new Program();
            program1.Show();
        }

        

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
