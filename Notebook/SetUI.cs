using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public class SetUI
    {
        public static DataGridView dataGridView { get; set; }
        public static void SetTable()
        {
            dataGridView.Invoke(new Action(() =>
            {
                dataGridView.Rows.Clear();
                foreach (var person in ManagerNotebook.listPerson)
                {
                    dataGridView.Rows.Add(person.id, person.fName, person.lName, person.number);
                }
            }));
        }

        public static void addRows(string id, string fName, string lName, string number)
        {
            dataGridView.Invoke(new Action(() =>
            {
                dataGridView.Rows.Add(id, fName, lName, number);
            }));

        }

        public static void RemovRows(string id)
        {
            dataGridView.Invoke(new Action(() =>
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }

                    if (dataGridView.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        dataGridView.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }));
        }

        public static void UpdateRows(string id, string fName, string lName, int number)
        {
            dataGridView.Invoke(new Action(() =>
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }

                    if (dataGridView.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        if (fName != "")
                        {
                            dataGridView.Rows[i].Cells[1].Value = fName;
                        }
                        if (lName != "")
                        {
                            dataGridView.Rows[i].Cells[2].Value = lName;
                        }
                        if (number.ToString() != "")
                        {
                            dataGridView.Rows[i].Cells[3].Value = number;
                        }
                    }
                }
            }));
        }

    }
}
