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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hello_world.Text = "";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "8";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "9";
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + "0";
        }
        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + " + ";
        }
        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + " - ";
        }
        private void Button_Click_umnoj(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + " * ";
        }
        private void Button_Click_delen(object sender, RoutedEventArgs e)
        {
            hello_world.Text = hello_world.Text + " / ";
        }
        private void Button_Click_ravno(object sender, RoutedEventArgs e)
        {
            String[] SplitStroki = new String[2];

            SplitStroki = hello_world.Text.Split(" ");


            switch (SplitStroki[1])
            {
                case "+":
                    {

                        double a = double.Parse(SplitStroki[0]);
                        double b = double.Parse(SplitStroki[2]);
                        double c = a + b;

                        hello_world.Text = Convert.ToString(c);
                        break;
                    }
                case "-":
                    {

                        double a = double.Parse(SplitStroki[0]);
                        double b = double.Parse(SplitStroki[2]);
                        double c = a - b;

                        hello_world.Text = Convert.ToString(c);
                        break;
                    }
                case "*":
                    {

                        double a = double.Parse(SplitStroki[0]);
                        double b = double.Parse(SplitStroki[2]);
                        double c = a * b;

                        hello_world.Text = Convert.ToString(c);
                        break;
                    }
                case "/":
                    {

                        double a = double.Parse(SplitStroki[0]);
                        double b = double.Parse(SplitStroki[2]);
                        double c = a / b;

                        hello_world.Text = Convert.ToString(c);
                        break;
                    }
            }


        }
    }
}
