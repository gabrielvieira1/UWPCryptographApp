using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace UWPCryptographApp
{
  public class HashGenerator
  {
    public void HashMessage(TextBox display)
    {
      try
      {
        byte[] inputBytes = Encoding.UTF8.GetBytes(display.Text);
        HashAlgorithmProvider hashAlgorithm = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha1);
        //HashAlgorithmProvider hashAlgorithm = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha256);
        IBuffer hashedBuffer = hashAlgorithm.HashData(CryptographicBuffer.CreateFromByteArray(inputBytes));
        string base64Hash = CryptographicBuffer.EncodeToBase64String(hashedBuffer);
        display.Text = base64Hash;
      }
      catch
      {

      }
    }
  }
}