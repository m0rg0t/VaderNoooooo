using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Noooooo.Resources;
using Coding4Fun.Phone.Controls;
using System.Device.Location;

namespace Noooooo
{    
    public partial class MainPage : PhoneApplicationPage
    {
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaPlayer = sender as MediaElement;
            //button1.Content = 
            this.no.Source = new Uri("/Nooo.mp3", UriKind.Relative);
            this.no.Volume = 100;
            this.no.Position = new TimeSpan(0, 0, 0, 0, 1);
            this.no.Play();
            //MediaElement 
        }


        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void ApplicationBarMenuItem_Click(object sender, EventArgs e) //author
        {
            AboutPrompt p = new AboutPrompt();
            p.Show("Anton Lenev (m0rg0t)", "@m0rg0t", "m0rg0t.Anton@gmail.com", @"http://m0rg0t.ru");
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e) //idea
        {
            AboutPrompt p = new AboutPrompt();
            AboutPersonItem item = new AboutPersonItem();
            item.WebSiteUrl = @"nooooooooooooooo.com";
            p.Show(item);
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationBarMenuItem_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Quote from site: This is not associated with Darth Vader, Star Wars etc... Just my part to add to the hilarity of the world. You're welcome");
        }
    }
}