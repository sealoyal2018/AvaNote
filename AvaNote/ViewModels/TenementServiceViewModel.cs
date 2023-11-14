using System;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;

namespace AvaNote.ViewModels;
internal class TenementServiceViewModel : INavigateView
{
    public string Title => "物业服务";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/menu.png")));
}
