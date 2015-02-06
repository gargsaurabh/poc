using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configit.Runtime;


namespace ConfigitWinClient
{
    public partial class Form1 : Form
    {

        ProductModel model = null;
        public Form1()
        {
            InitializeComponent();
            model = ProductModel.CreateFromVT("SaveTheWhales.vtz");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDropDowns();

        }

        private void LoadDropDowns()
        {
            

            cbColor.SelectedIndexChanged -= cbColor_SelectedIndexChanged;
            cbPrint.SelectedIndexChanged -= cbPrint_SelectedIndexChanged;
            cbSize.SelectedIndexChanged -= cbSize_SelectedIndexChanged;

            cbColor.Items.Clear();


            cbColor.Text = string.Empty;
            cbColor.Items.AddRange(model.AllVariables["color"].Values.ToArray());

            cbPrint.Items.Clear();

            cbPrint.Text = string.Empty;
            cbPrint.Items.AddRange(model.AllVariables["print"].Values.ToArray());

            cbSize.Items.Clear();
            cbSize.Text = string.Empty;
            cbSize.Items.AddRange(model.AllVariables["size"].Values.ToArray());

            cbColor.SelectedIndexChanged += cbColor_SelectedIndexChanged;
            cbPrint.SelectedIndexChanged += cbPrint_SelectedIndexChanged;
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;

        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.AllVariables["color"].Assign(cbColor.SelectedItem.ToString());
            SetAssignment();
        }

        private void cbPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.AllVariables["print"].Assign(cbPrint.SelectedItem.ToString());
            SetAssignment();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.AllVariables["size"].Assign(cbSize.SelectedItem.ToString());
            SetAssignment();
        }

        void SetAssignment()
        {
            cbColor.SelectedIndexChanged -= cbColor_SelectedIndexChanged;
            cbPrint.SelectedIndexChanged -= cbPrint_SelectedIndexChanged;
            cbSize.SelectedIndexChanged -= cbSize_SelectedIndexChanged;


            //cbPrint.Items.Clear();
            //var legealValues = model.AllVariables["print"].GetLegalValueString();
            //var valueCollections = legealValues.Split(',');
            cbPrint.SelectedItem = null;
            cbPrint.SelectedItem = model.AllVariables["print"].AssignedValue;

            cbColor.SelectedItem = null;
            cbColor.SelectedItem = model.AllVariables["color"].AssignedValue;

            cbSize.SelectedItem = null;
            cbSize.SelectedItem = model.AllVariables["size"].AssignedValue;

            cbColor.SelectedIndexChanged += cbColor_SelectedIndexChanged;
            cbPrint.SelectedIndexChanged += cbPrint_SelectedIndexChanged;
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            model.Reset();
            LoadDropDowns();
        }

    }
}
