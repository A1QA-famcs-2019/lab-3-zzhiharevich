using Calculator.Resources;
using System;
using System.Collections.Generic;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.Pages
{
    public class ButtonsPage
    {
        public Button ButtonAdd { get; }
        public Button ButtonSubtract { get; }
        public Button ButtonMultiply { get; }
        public Button ButtonDivide { get; }
        public Button ButtonGetResult { get; }
        public Label LabelResult { get; }

        private readonly List<Button> buttons;

        public Button MemoryButtonStore { get; }
        public Button MemoryButtonAdd { get; }
        public Button MemoryButtonSub { get; }
        public Button MemoryButtonRecall { get; }
        public Button MemoryButtonClear { get; }

        public ButtonsPage(Window window)
        {
            ButtonAdd = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.ButtonAddID));
            ButtonSubtract = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.ButtonSubtractID));
            ButtonMultiply = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.ButtonMultiplyID));
            ButtonDivide = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.ButtonDivideID));
            ButtonGetResult = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.ButtonGetResultID));
            LabelResult = window.Get<Label>(SearchCriteria.ByAutomationId(Resource.LabelResultID));

            buttons = new List<Button>();
            foreach (string id in Resource.NumericButtonsID)
                buttons.Add(window.Get<Button>(SearchCriteria.ByAutomationId(id)));

            MemoryButtonStore = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.MemoryButtonStoreID));
            MemoryButtonAdd = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.MemoryButtonAddID));
            MemoryButtonSub = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.MemoryButtonSubtractID));
            MemoryButtonRecall = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.MemoryButtonRecallID));
            MemoryButtonClear = window.Get<Button>(SearchCriteria.ByAutomationId(Resource.MemoryButtonClearID));
        }

        public void EnterNumber(int value)
        {
            if (!(value >= 0 && value <= 9))
                throw new ArgumentException("Value should be in closed range 0..9");
            buttons[value].Click();

        }
        
        public void EnterNumber(string value)
        {
            foreach (char c in value)
                EnterNumber(c - '0');
        }

    }
}
