using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using Stylet;

namespace AvaNote.Models;
public class Contract: PropertyChangedBase
{
    private string name;
    private string roleName;
    private string mobile;
    private string avatar;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            NotifyOfPropertyChange();
        }
    }
    public string RoleName
    {
        get
        {
            return roleName;
        }
        set
        {
            roleName = value;
            NotifyOfPropertyChange();
        }
    }
    public string Mobile
    {
        get
        {
            return mobile;
        }
        set
        {
            mobile = value;
            NotifyOfPropertyChange();
        }
    }
    public string Avatar
    {
        get
        {
            return avatar;
        }
        set
        {
            avatar = value;
            NotifyOfPropertyChange();
        }
    }

    public Bitmap? Icon
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Avatar))
                return null;
            return new Bitmap(AssetLoader.Open(new Uri(Avatar)));
        }
    }
}
