using System.Collections.Generic;

namespace Calculator.Resources
{
    public static class Resource
    {

        public static string PathToCalculatorApp { get; } = "C:\\Windows\\System32\\calc1.exe";
        public static string MainPageName { get; } = "Калькулятор";

        public static string ButtonAddID { get; } = "93";
        public static string ButtonSubtractID { get; } = "94";
        public static string ButtonMultiplyID { get; } = "92";
        public static string ButtonDivideID { get; } = "91";
        public static string ButtonGetResultID { get; } = "121";
        public static string LabelResultID { get; } = "158";

        public static string MemoryButtonStoreID { get; } = "124";
        public static string MemoryButtonAddID { get; } = "125";
        public static string MemoryButtonSubtractID { get; } = "126";
        public static string MemoryButtonRecallID { get; } = "123";
        public static string MemoryButtonClearID { get; } = "122";

        public static List<string> NumericButtonsID { get; } = new List<string>() {
            "130", "131","132","133","134","135","136","137","138","139"};
    }
}
