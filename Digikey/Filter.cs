using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digikey
{
    public partial class Filter : Form
    {
       


        
        public Filter()
        {
            InitializeComponent();
            pTransistor.Hide();
            pConnectors.Hide();
            List<string> transistorCols = new List<string> { "Mfr", "Series", "Transistor Type", "Current - Collector (Ic) (Max)", " Package" };
            List<string> ConnectorCols = new List<string> { "Mfr", "Number of Positions", "Contact Type", "Number of Rows", "Fastening Type" };
            List<ListBox> connectorListBoxes = new List<ListBox> { lb01, lb02, lb03, lb04, lb05 };
            List<ListBox> transistorListBoxes = new List<ListBox> { listBox2, listBox3, listBox4, listBox5, listBox6 };

            List<List<string>> TransistorResult = parseFile("transistors.txt");
            List<List<string>> connectorResult = parseFile("connectors.txt");

            populateListBoxes(TransistorResult, transistorCols, transistorListBoxes);
            populateListBoxes(connectorResult, ConnectorCols, connectorListBoxes);
            convertToDtconn(connectorResult);
            convertToDttrans(TransistorResult);


        }


        public void showConnector()
        {
            pTransistor.Hide();
            pConnectors.Show();
            dgvConnectors.Show();
            dgv.Hide();
        }

        public void showTransistor()
        {
            pConnectors.Hide();
            pTransistor.Show();
            dgvConnectors.Hide();
            dgv.Show();

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        public List<List<string>> parseFile(string filename)
        {
            List<List<string>> tempList = new List<List<string>>();
            foreach (string line in System.IO.File.ReadLines(filename))
            {
                List<string> temp = new List<string>();
                string[] myLine = line.Split('|');
                foreach (string col in myLine)
                {
                    temp.Add(col);
                }
                tempList.Add(temp);
            }
            return (tempList);
        }

        public void populateListBoxes(List<List<string>> file, List<string> match, List<ListBox> listBoxes)
        {
            List<string> vals = new List<string>();
            for (int z = 0; z < match.Count; z++)
            {

            
                for (int a = 0; a < file[0].Count; a++)
                {
                    vals = new List<string>();
                    if (file[0][a].Equals(match[z]))
                    {
                        
                        for (int b = 1; b < file.Count; b++)
                        {
                            if (b == 1) vals.Add(file[b][a]);
                            else
                            {
                                bool found = false;
                                for (int c = 0; c < vals.Count; c++)
                                {
                                    if (vals[c].Equals(file[b][a]))
                                    {
                                        found = true;
                                    }
                                }
                                if (!found) vals.Add(file[b][a]);
                            }
                        }
                        break;
                    }
                }
                for (int d = 0; d < vals.Count; d++)
                {
                    listBoxes[z].Items.Add(vals[d]);
                }
                    
            }
        }

        public void convertToDttrans(List<List<string>> file)
        {
            for (int a = 0; a < file[0].Count; a++)
            {
                dgv.Columns.Add(file[0][a], file[0][a]);
            }
            for (int a = 0; a < file.Count; a++)
            {
                dgv.Rows.Add(file[a].ToArray());                
            }

        }
        public void convertToDtconn(List<List<string>> file)
        {
            for (int a = 0; a < file[0].Count; a++)
            {
                dgvConnectors.Columns.Add(file[0][a], file[0][a]);
            }
            for (int a = 0; a < file.Count; a++)
            {
                dgvConnectors.Rows.Add(file[a].ToArray());
            }

        }

        private void DgvConnectors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Overlay.changeOverlay(Overlay.product);
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Overlay.changeOverlay(Overlay.product);
        }
    }
}
