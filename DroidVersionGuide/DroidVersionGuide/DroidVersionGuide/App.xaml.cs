using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Unity.Injection;
using Xamarin.Forms.Xaml;
using DroidVersionGuide.Views;
using DroidVersionGuide.Service;
using DroidVersionGuide.ViewModels;
using DroidVersionGuide.Repository;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DroidVersionGuide
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>("MainPage");
            containerRegistry.RegisterForNavigation<DetailPage>("DetailPage");
            containerRegistry.RegisterInstance(new Service.Service(new DroidVersionRepository(DAL.Versions)));
            containerRegistry.Register<IService, Service.Service>();
        }
    }
}
