using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace Bingo.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand => _navigateCommand
            ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public ViewAViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page 1";
        }

        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("ViewB");
        }
    }
}
