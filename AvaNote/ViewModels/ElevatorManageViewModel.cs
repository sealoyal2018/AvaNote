using System;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;

namespace AvaNote.ViewModels;
internal class ElevatorManageViewModel : INavigateView
{
    public string Title => "电梯管理";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/elevator.png")));
}
