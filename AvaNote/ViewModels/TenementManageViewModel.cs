using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Media.Imaging;
using Avalonia.Platform;
using AvaNote.Interface;

namespace AvaNote.ViewModels;
internal class TenementManageViewModel: INavigateView
{
    public string Title => "物业管理";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/manage.png")));
}
