﻿using BlazingPizza.Backend.IoC;
using BlazingPizza.BusinessObjects.ValueObjects;
using BlazingPizza.Frontend.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlazingPizza.WPFClient;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        RegisterServices();
    }

    void RegisterServices()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddWpfBlazorWebView();




        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        //Services.AddBlazingPizzaFrontendServices(
        //    Configuration.GetSection("BlazingPizzaEndpoints")
        //    .Get<EndpointsOptions>());

        services.AddBlazingPizzaDesktopServices()
            .AddBlazingPizzaBackendServices(
            configuration.GetConnectionString("BlazingPizzaDB"),
            configuration["ImagesBaseUrl"]
            );

        Resources.Add("Services", services.BuildServiceProvider()); 
    }
}

//**** Agregar un cliente Windows Forms ****
//**** Agregar un cliente MAUI ***
