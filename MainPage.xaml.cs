using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PBKDF2_Generator_WP.Resources;
using System.Security.Cryptography;
using System.Text;

namespace PBKDF2_Generator_WP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Konstruktor
        public MainPage()
        {
            InitializeComponent();

            // Beispielcode zur Lokalisierung der ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void genbtn_Click(object sender, RoutedEventArgs e)
        {
            string use = svctb.Text;
            while (use.Length < 8)
            {
                use += "O";
            }
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(keytb.Text, Encoding.UTF8.GetBytes(use.ToLower()), 4096);
            String res2898 = Convert.ToBase64String(rfc.GetBytes(6)).Replace("=", "");
            MessageBoxResult res = MessageBox.Show(res2898, "Result-Zum Speichern in Zwischenablage OK", MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                System.Windows.Clipboard.SetText(res2898);
            }
        }

        // Beispielcode zur Erstellung einer lokalisierten ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // ApplicationBar der Seite einer neuen Instanz von ApplicationBar zuweisen
        //    ApplicationBar = new ApplicationBar();

        //    // Eine neue Schaltfläche erstellen und als Text die lokalisierte Zeichenfolge aus AppResources zuweisen.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Ein neues Menüelement mit der lokalisierten Zeichenfolge aus AppResources erstellen
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}