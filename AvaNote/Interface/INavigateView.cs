using Avalonia.Media.Imaging;

namespace AvaNote.Interface;
public interface INavigateView
{
    public string Title { get; }
    public Bitmap? Icon { get; }
}
