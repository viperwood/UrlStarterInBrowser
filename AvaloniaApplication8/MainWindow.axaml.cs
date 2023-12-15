using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication8;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Tab(object? sender, RoutedEventArgs e)
    {

        string url = "http://www.microsoft.com";
        string brayser = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
        Process.Start(brayser,url);

    }
}