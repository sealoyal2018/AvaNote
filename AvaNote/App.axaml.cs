using Avalonia.Markup.Xaml;

using AvaNote.Interface;
using AvaNote.ViewModels;

using Stylet;

using StyletIoC;

namespace AvaNote;
public partial class App : StyletApplication<ShellViewModel>
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        base.Initialize();
    }

    protected override void ConfigureIoC(IStyletIoCBuilder builder)
    {
        builder.Bind<INavigateView>().To<DashbardViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<HomeViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<TenementManageViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<TenementServiceViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<ElevatorManageViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<MaintainViewModel>().InSingletonScope();
        builder.Bind<INavigateView>().To<DataStatisticsViewModel>().InSingletonScope();
    }
}