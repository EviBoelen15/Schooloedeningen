using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace FileStreamDemo
{
    public partial class MainWindow : Window
    {
        private string _currentFile;
        private string _currentFolder;
        
        public MainWindow()
        {
            InitializeComponent();

            _currentFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {InitialDirectory = _currentFolder};

            if (dialog.ShowDialog() == true)
            {
                _currentFile = dialog.FileName;
                _currentFolder = Directory.GetParent(_currentFile).ToString();
                fileTextBox.Text = _currentFile;
            }
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = null;
            try
            {
                FileStream fileStream = new FileStream(_currentFile,
                                                    FileMode.Open,
                                                    FileAccess.Read);
                reader = new StreamReader(fileStream);
                mainTextBox.Text = reader.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(fileTextBox.Text + " niet gevonden!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                //or use the shorter null propagation syntax:
                //reader?.Close();
            }
        }

        private void appendButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fileStream = new FileStream(_currentFile,
                                                    FileMode.Append,
                                                    FileAccess.Write);
                writer = new StreamWriter(fileStream);
                // Append content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        private void replaceButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fileStream = new FileStream(_currentFile,
                                                    FileMode.Create,
                                                    FileAccess.Write);
                writer = new StreamWriter(fileStream);
                // Replace content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer?.Close();
            }
        }
    }
}
