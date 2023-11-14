﻿using System.Collections.Generic;

using Avalonia.Controls;
using Avalonia.Input;

using AvaNote.Interface;
using Stylet;

namespace AvaNote.ViewModels;
public class ShellViewModel : Conductor<INavigateView> {
    private int navigateIndex;
    public BindableCollection<INavigateView> Navigates { get; }
    public int NavigateIndex { get => navigateIndex; set { navigateIndex = value; NotifyOfPropertyChange(); } }

    public ShellViewModel(IEnumerable<INavigateView> navigates)
    {
        Navigates = new BindableCollection<INavigateView>(navigates);
        NavigateIndex = 0;
    }

    public void NaviateTo(SelectionChangedEventArgs e)
    {
        if(e.AddedItems.Count > 0)
        {
            ActivateItem(e.AddedItems[0] as INavigateView);
        }
    }

}
