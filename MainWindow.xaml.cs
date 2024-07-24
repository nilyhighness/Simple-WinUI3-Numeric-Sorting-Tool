using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App4
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private string MyString;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MyString = this.text1.Text;
            string[] parts = MyString.Split(" ");
            int[] numbers= new int[parts.Length];
            for (int i=0;i<parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }
            string SortedArray=App4.SortArray.Sorter(numbers);
            this.t2.Text = SortedArray;
        }
    }
    public class SortArray
    {
        public static string Sorter(int[] List)
        {
            for (int i = 0; i < List.Length; i++)
            {
                for (int j = i + 1; j < List.Length; j++)
                {
                    if (List[i] < List[j])
                    {
                        int temp = List[i];
                        List[i] = List[j];
                        List[j] = temp;
                        //����һ���м�ֵ����ʱ�洢����һ����Ȼ����һ�滻���ﵽ�����Ŀ�ġ�
                    }
                }
            }
            string[] Temped= List.Select(x => x.ToString()).ToArray();
            string ans=String.Join(" ",Temped);
            return ans;
        }
    }
}

