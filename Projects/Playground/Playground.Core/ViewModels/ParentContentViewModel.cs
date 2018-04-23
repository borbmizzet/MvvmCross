using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class ParentContentViewModel : MvxViewModel
    {


        public ParentContentViewModel()
        {
            ChildViewModel = new ChildContentViewModel();
        }
        private ChildContentViewModel _childViewModel;
        public ChildContentViewModel ChildViewModel
        {
            get { return _childViewModel; }
            private set { SetProperty(ref _childViewModel, value); }
        }

        public override void ViewAppeared()
        {
            ChildViewModel.SetText();
            base.ViewAppeared();
        }
    }
}
