using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Integration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestAddin
{
  //Наследуемый класс
  class MdiWindowCmd : Command
    {


        //Поле=Переменная
        MdiWindow _myWindow;
        //Конструктор, т.к. имя совпадает с именем класса
        public MdiWindowCmd(WindowManager wndManager)
        {
            //Задание command key
            base.Key = "TestAddin.MdiWindowCmd";


            //ElementHost wpfHost = new ElementHost();
            //HelloWorldWpf helloWorldWpf = new HelloWorldWpf();
            //wpfHost.Child = helloWorldWpf;


            _myWindow = wndManager.CreateMdiWindow("CreateMdiWindow", "TestMdiWindow", new HelloWorldCtrl());


            // Create an event handler for the window closed event
            _myWindow.Closing += _myWindow_Closing;
            this.ExecuteOnCheckedChange = false;

            _myWindow.Form.TopMost = true;

        }

        private void _myWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Checked = false;

            _myWindow.Hide();
            e.Cancel = true;
        }


        //Перезапись базового класса Execute()
        public override void Execute()
      
        {
            try
            {
                if (_myWindow.Visible)
                {
                    _myWindow.Hide();
                }
                else
                {
                    _myWindow.Show();
                    //"Плавающее" окно (иначе займет все пространство view)
                   _myWindow.Float();
                }
                base.Execute();
            }
            catch (Exception)
            {
                //Оператор
               // throw;
            }

            
        }

    }
}