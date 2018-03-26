using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestAddin
{
    public class TestAddin : IAddin
    {
        //private string description;

        public string Description
        {
            get { return "E3D Addin"; }
            //set { description = "E3D Addin"; }
        }

        public string Name
        {
            get { return "E3D Addin"; }
        }


        public void Start(ServiceManager serviceManager)
        {
            //System.Windows.Forms.MessageBox.Show("Test Addin");
            WindowManager windowManager = (WindowManager)serviceManager.GetService(typeof(WindowManager));
            MdiWindowCmd mdiWindowCmd = new MdiWindowCmd(windowManager);

            
            //Создание и регистрация команды
            CommandManager commandManager = (CommandManager)serviceManager.GetService(typeof(CommandManager));
            //Добавляем в commands E3D новую команду:
            commandManager.Commands.Add(mdiWindowCmd);

            
        }

        public void Stop()
        {
            
        }

        internal class Database1DataSet
        {
            internal string DataSetName;

            public Database1DataSet()
            {
            }

            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        }

        internal class Database1DataSetTableAdapters
        {
            internal class TableTableAdapter
            {
                public bool ClearBeforeFill { get; internal set; }
            }
        }
    }


}
