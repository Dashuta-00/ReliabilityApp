using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public partial class ElementsForm : Form
    {
        List<Form> elementForms = new List<Form>(0);
        string elementType;
        public ElementsForm(string elType)
        {
            elementType = elType;
            InitializeComponent();
            if (elementType == "Резисторы")
                labelListOfElement.Text = "Список резисторов:";
            if (elementType == "Конденсаторы")
                labelListOfElement.Text = "Список конденсаторов:";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (elementType == "Резисторы")
                new ResistorForm(ref elementForms, ref elementListBox).Show();
            if (elementType == "Конденсаторы")
                new CapacitorForm(ref elementForms, ref elementListBox).Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = elementListBox.SelectedIndices.Count; i > 0; i--)
            {
                int index = elementListBox.SelectedIndices[i - 1];
                elementListBox.Items.RemoveAt(index);
                elementForms[index].Dispose();
                elementForms.RemoveAt(index);
            }
        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (elementListBox.Items.Count > 0)
            {
                new Coefficients(elementForms).Show();
                Close();
            }
            else
                MessageBox.Show("Необходимо добавить хотя бы 1 элемент", "Ошибка");
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            foreach (int index in elementListBox.SelectedIndices)
                elementForms[index].Show();
        }
    }
}
