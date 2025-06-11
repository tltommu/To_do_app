using CommunityToolkit.Mvvm.Input;
using To_do_app.Models;

namespace To_do_app.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}