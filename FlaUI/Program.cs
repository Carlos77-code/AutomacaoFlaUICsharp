using System;
using System.Windows;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = FlaUI.Core.Application.Launch("D:\\carlo\\Projeto\\FlaUIPractice-master\\FlaUIPractice\\FlaUiTests\\Resources\\WinFormsApplication.exe");

            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("ContextMenu")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("TextBox")).AsTextBox().Enter("Carlos");
            mainWindow.FindFirstDescendant(cf.ByName("Fechar")).AsButton().Click();

        }
    }
}