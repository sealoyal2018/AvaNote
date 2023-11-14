using System;
using System.Linq;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;
using AvaNote.Models;

using Stylet;

namespace AvaNote.ViewModels;
internal class HomeViewModel : Stylet.Screen, INavigateView
{
    public string Title => "工作台";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/home.png")));

}
