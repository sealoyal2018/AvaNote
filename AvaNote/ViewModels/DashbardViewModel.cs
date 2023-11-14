using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Media.Imaging;
using Avalonia.Platform;

using AvaNote.Interface;
using AvaNote.Models;

using Stylet;

namespace AvaNote.ViewModels;
internal class DashbardViewModel: Stylet.Screen, INavigateView
{
    public string Title => "总览";
    public Bitmap? Icon => new Bitmap(AssetLoader.Open(new Uri("avares://AvaNote/Assets/menu.png")));


    private BindableCollection<TaskItem> tasks;
    private BindableCollection<Contract> contracts;
    public BindableCollection<TaskItem> Tasks
    {
        get
        {
            return tasks;
        }
        set
        {
            tasks = value;
            NotifyOfPropertyChange();
        }
    }
    public BindableCollection<Contract> Contracts
    {
        get
        {
            return contracts;
        }
        set
        {
            contracts = value;
            NotifyOfPropertyChange();
        }
    }

    public DashbardViewModel()
    {
        var tasks = Enumerable.Range(0, 10).Select(v => new TaskItem { Title = $"任务{v}", DateTime = new DateTime(2023, 11, v+1, 10,10,10) });
        this.tasks = new BindableCollection<TaskItem>(tasks);

        var contracts = Enumerable.Range(1, 20)
            .Select(v => new Contract
            {
                Name = "临冬冬",
                RoleName = "信息管理员",
                Mobile = "13648757849",
                Avatar = "avares://AvaNote/Assets/avatar.png"
            });
        this.Contracts = new BindableCollection<Contract>(contracts);
    }
}
