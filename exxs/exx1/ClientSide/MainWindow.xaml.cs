using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace exx1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connectToServer(object sender, RoutedEventArgs e)
        {
            connectToServer();
        }

        private void connectToServer()
        {
            // initialize the connection
            try
            {
                client = new TcpClient("localhost", 13000);
                sendMsg("New Connection.");
            }
            catch (SocketException err)
            {
                formPrint("SocketException", err);
            }
            
        }

        private void formPrint(string msg, params object[] o)
        {
            var endl = "\r\n";
            recivMsg.Foreground = o.Length == 0 ? Brushes.Black : Brushes.Red;
            recivMsg.Text += "*************************************" + endl;
            recivMsg.Text += DateTime.Now + endl;
            recivMsg.Text += msg + endl;
            recivMsg.Text += "*************************************" + endl;
            recivMsg.ScrollToEnd();
        }

        private void sendMsg(object sender, RoutedEventArgs e)
        {
            sendMsg(goMsg.Text);
            goMsg.Text = null;
        }

        private void sendMsg(string message)
        {
            try
            {
                var stream = client.GetStream();
                var data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                data = new byte[4096];
                var response = "";

                var i = stream.Read(data, 0, data.Length);
                response = Encoding.UTF8.GetString(data, 0, i);
                response = response.TrimEnd('\0');
                if (response.Contains("ERROR"))
                    throw new ServerException(response);
                else
                    formPrint(response);
            }
            catch (ArgumentNullException err)
            {
                formPrint("ArgumentNullException", err);
            }
            catch (ServerException err)
            {
                formPrint("ServerException", err);
            }
            catch (NullReferenceException err)
            {
                formPrint("NullReferenceException", err);
            }
        }

        private TcpClient client = null;

        private void uploadFile(object sender, RoutedEventArgs e)
        {
            try
            {
                var op = new Microsoft.Win32.OpenFileDialog();
                op.ShowDialog();
                var filestream = op.OpenFile();
                filestream.CopyTo(client.GetStream());
                formPrint(op.FileName + " Send.");
            }
            catch (ArgumentNullException err)
            {
                formPrint("ArgumentNullException", err);
            }
            catch (NullReferenceException)
            {
                formPrint("NullReferenceException");
            }

        }

        private void dropCon(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try { client.Close(); }
            catch (NullReferenceException)
            {
                formPrint("NullReferenceException");
            }
        }

        private void navMu(object sender, MouseButtonEventArgs e)
        {
            connectToServer();
        }

        private void cover(object sender, MouseButtonEventArgs e)
        {
            return;
        }
    }
}
