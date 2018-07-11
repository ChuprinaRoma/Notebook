using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notebook
{
    public class ManagerNotebook
    {
        public static List<ModelPerson> listPerson = null;
        DAOSql dAOSql = null;

        public ManagerNotebook()
        {
            dAOSql = new DAOSql();
            Read();
        }

        public void Create(int id, string fName, string lName, int number)
        {
            new Thread(() =>
            {
                dAOSql.Create(id, fName, lName, number);
                SetUI.addRows(id.ToString(), fName, lName, number.ToString());
            }).Start();
        }

        public void Read()
        {
            new Thread(() =>
            {
                dAOSql.Read();
                SetUI.SetTable();
                listPerson = null;
            }).Start();
        }
        public void Read(string type, string val)
        {
            new Thread(() =>
            {
                dAOSql.Read(type, val);
                SetUI.SetTable();
                listPerson = null;
            }).Start();
        }

        public void Update(int id, string fName, string lName, int number)
        {
            new Thread(() =>
            {
                dAOSql.Update(id, fName, lName, number);
                SetUI.UpdateRows(id.ToString(), fName, lName, number);
            }).Start();
        }

        public void Delet(int id)
        {
            new Thread(() =>
            {
                dAOSql.Delet(id);
                SetUI.RemovRows(id.ToString());
            }).Start();
        }
    }
}
