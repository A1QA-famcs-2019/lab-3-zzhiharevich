using Calculator.Resources;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    public class CalculatorApp
    {

        private CalculatorApp() { }

        private static CalculatorApp instance = null;
        private static Application app = null;

        public static CalculatorApp GetInstance
        {
            get
            {
                return instance != null ? instance : new CalculatorApp();
            }
        }

        public void Launch()
        {
            app = app != null ? app : Application.Launch(Resource.PathToCalculatorApp);
        }

        public Window GetWindow()
        {
            return app.GetWindow(Resource.MainPageName);
        }

        public void Close()
        {
            if (app == null)
                return;

            app.Close();
            app.Dispose();
            app = null;
            instance = null;
        }


        ~CalculatorApp()
        {
            Close();
        }
        
    }
}
