using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows;
//using GeoLib.Proxies;
////using GeoLib.Contracts;
//using GeoLib.Client.Contracts;
using System.Threading;
using System.Diagnostics;
using GeoLib.Client.ServiceReference1;
using GeoLib.Contracts;

namespace GeoLib.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "UI Running on Thread " + Thread.CurrentThread.ManagedThreadId +
                " | Process " + Process.GetCurrentProcess().Id.ToString();
        }

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            if (txtZipCode.Text != "")
            {
                ServiceReference1.IGeoService proxy1 = new GeoServiceClient();
                ZipCodeData data =proxy1.GetZipInfo(txtZipCode.Text);

                //GeoClient proxy = new GeoClient("webEP");

                //ZipCodeData data = proxy.GetZipInfo(txtZipCode.Text);
                if (data != null)
                {
                    lblCity.Content = data.City;
                    lblState.Content = data.State;
                }

                
            }
        }

        private void btnGetZipCodes_Click(object sender, RoutedEventArgs e)
        {
            if (txtState.Text != null)
            {
                //ServiceReference1.IGeoService proxy1 = new GeoServiceClient();
        
                //IEnumerable<ZipCodeData> data = proxy1.GetZipsByState(txtState.Text);
                //if (data != null)
                //    lstZips.ItemsSource = data;

            }
        }

        private void btnMakeCall_Click(object sender, RoutedEventArgs e)
        {
            //EndpointAddress address = new EndpointAddress("net.tcp://localhost:8010/MessageService");
            //Binding binding = new NetTcpBinding();

            //ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>(binding, address);

            ////ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>("");
            //IMessageService proxy = factory.CreateChannel();

            //proxy.ShowMessage(txtMessage.Text);

            //factory.Close();
        }
    }
}
