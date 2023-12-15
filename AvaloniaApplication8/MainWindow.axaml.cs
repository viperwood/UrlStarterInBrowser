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
        Process process = new Process();
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = "https://www.youtube.com/watch?v=lHpYyYtkmrw";
        process.Start();
    }
}