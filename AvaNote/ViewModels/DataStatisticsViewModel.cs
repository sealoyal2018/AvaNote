using System;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;

namespace AvaNote.ViewModels;
internal class DataStatisticsViewModel : INavigateView
{
    public string Title => "数据统计";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/statistics.png")));
}
