using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace University_StudentPractice.Components
{
    
    public class myNavigation
    {
        private Frame _mainFrame;

        public myNavigation(Frame mainFrame)
        {
            _mainFrame = mainFrame;
        }
        public void NavigateToPage(Page page)
        {
            _mainFrame.Navigate(page);
        }
        public void GoBack()
        {
            if (_mainFrame.CanGoBack)
            {
                _mainFrame.GoBack();
            }
        }
        public void GoForward()
        {
            if(  _mainFrame.CanGoForward);
            {
                _mainFrame.GoForward();
            }
        }
        public void Refresh() 
        {
            _mainFrame.Refresh();
        }
    }

}
