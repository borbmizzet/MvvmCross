using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class ChildContentViewModel : MvxViewModel
    {
        private string _test1;

        public string Test1
        {
            get { return _test1; }
            private set { SetProperty(ref _test1, value); }
        }

        private string _test2;

        public string Test2
        {
            get { return _test2; }
            private set { SetProperty(ref _test2, value); }
        }

        public override async Task Initialize()
        {
            await Task.Yield();
        }

        public void SetText()
        {
            Test1 = "Bound Text1";
            Test2 = "Bound Text2";
        }
    }
}
