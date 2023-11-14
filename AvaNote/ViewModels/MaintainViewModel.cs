using System;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;

namespace AvaNote.ViewModels;
internal class MaintainViewModel : INavigateView
{
    public string Title => "维修管理";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/maintain.png")));
}
