using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class TableStyle
    {
        public string[] header;
        public List<string[]> data = new List<string[]>();
        public Panel display = new Panel();
        public List<Label[]> lblData = new List<Label[]>();
        int rows;
        int cols;
        int[] wSize;
        public TableStyle(string[] header, List<string[]> data, bool edit, bool delete)
        {
            this.header = header;
            this.data = data;
            rows = data.Count + 1; ;
            cols = header.Length;
            wSize = new int[cols];
            for(int i = 0; i < cols; i++)
            {
                wSize[i] = Math.Max(wSize[i], header[i].Length * 11 + 30);
            }
            for(int i = 1; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i - 1][j] == null)
                        continue;
                    wSize[j] = Math.Max(wSize[j], data[i - 1][j].Length * 11 + 30);
                }
            }
            display.Dock = DockStyle.Fill;
            display.AutoScroll = true;
            CreateView();
        }
        void CreateView()
        {
            var lbls = new Label[cols];
            for(int i = 0; i < cols; i++)
            {
                Label lbl = createBox(header[i], new Size(wSize[i], 30));
                if(i != 0)
                {
                    lbl.Location = new Point(lbls[i - 1].Right, lbls[i - 1].Top);
                }
                lbls[i] = lbl;
            }
            lblData.Add(lbls);
            display.Controls.AddRange(lbls);
            for(int i = 1; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Label lbl = createBox(data[i - 1][j], new Size(wSize[j], 30));
                    lbl.Location = new Point(lblData[i - 1][j].Left, lblData[i - 1][j].Bottom);
                    lbls[j] = lbl;
                }
                lblData.Add(lbls);
                display.Controls.AddRange(lbls);
            }
        }
        Label createBox(string text, Size size)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            lbl.Font = new Font(lbl.Font.FontFamily, 14);
            lbl.Size = size;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            return lbl;
        }
    }
}
