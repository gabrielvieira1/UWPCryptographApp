using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCryptographApp
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    Library lib = new Library();
    HashGenerator hasher = new HashGenerator();
    public MainPage()
    {
      this.InitializeComponent();
    }
    private void Open_Click(object sender, RoutedEventArgs e)
    {
      lib.Open(Display);
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
      lib.Save(Display);
    }

    private void Encrypt_Click(object sender, RoutedEventArgs e)
    {
      lib.Encrypt(Display);
    }

    private void Decrypt_Click(object sender, RoutedEventArgs e)
    {
      lib.Decrypt(Display);
    }
    private void HashMessage_Click(object sender, RoutedEventArgs e)
    {
      hasher.HashMessage(Display);
    }
  }
}
