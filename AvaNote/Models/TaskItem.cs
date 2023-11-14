using System;
using Stylet;

namespace AvaNote.Models;
public class TaskItem: PropertyChangedBase
{
    private string title;
    private DateTime dateTime;

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
            NotifyOfPropertyChange();
        }
    }
    public DateTime DateTime
    {
        get
        {
            return dateTime;
        }
        set
        {
            dateTime = value;
            NotifyOfPropertyChange();
        }
    }
}
