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
    public class ViewBViewModel : ViewModelBase, INavigationAware
    {
        public ViewBViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("name");
        }
    }
}
