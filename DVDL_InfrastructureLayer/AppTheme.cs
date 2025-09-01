using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DVDL_InfrastructureLayer
{
    public static class AppTheme
    {
        public static readonly Color Background = ColorTranslator.FromHtml("#F4F6F9");
        public static readonly Color Primary = ColorTranslator.FromHtml("#007BFF");     // أزرق
        public static readonly Color Secondary = ColorTranslator.FromHtml("#6C757D");   // رمادي غامق
        public static readonly Color Text = ColorTranslator.FromHtml("#212529");        // نص

        public static readonly Color CellBg = Color.White;
        public static readonly Color AltCellBg = ColorTranslator.FromHtml("#EEF2F7");
        public static readonly Color GridLines = ColorTranslator.FromHtml("#E1E5EB");

        public static readonly Color SelBg = Primary;
        public static readonly Color SelFg = Color.White;

        public static void ApplyTheme(Control container)
        {
            container.BackColor = Background;

            foreach (Control control in container.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Primary;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = Text;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Text;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is Panel pnl)
                {
                    if (pnl.Name?.ToLower().Contains("header") == true)
                        pnl.BackColor = Secondary;
                    else
                        pnl.BackColor = Background;
                }
                else if (control is DataGridView dgv)
                {
                    StyleDataGridView(dgv);

                    if (dgv.Tag?.ToString() != "themed")
                    {
                        dgv.DataBindingComplete += (s, e) => StyleDataGridView(dgv);
                        dgv.Tag = "themed";
                    }
                }
                else if (control is PictureBox pb)
                {
                    StylePictureBox(pb, Secondary, 2, 15); // 2px border + 15px rounded
                }

                // Recursive
                if (control.HasChildren)
                    ApplyTheme(control);
            }
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            dgv.BackgroundColor = Background;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = GridLines;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;   
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; 
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 36;

            dgv.RowHeadersVisible = false;

            dgv.DefaultCellStyle.BackColor = CellBg;
            dgv.DefaultCellStyle.ForeColor = Text;
            dgv.DefaultCellStyle.SelectionBackColor = SelBg;
            dgv.DefaultCellStyle.SelectionForeColor = SelFg;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = AltCellBg;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Text;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = SelBg;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = SelFg;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 28;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.DefaultCellStyle.BackColor = CellBg;
                col.DefaultCellStyle.ForeColor = Text;
                col.DefaultCellStyle.SelectionBackColor = SelBg;
                col.DefaultCellStyle.SelectionForeColor = SelFg;

                if (col is DataGridViewLinkColumn linkCol)
                {
                    linkCol.LinkColor = Primary;
                    linkCol.ActiveLinkColor = Primary;
                    linkCol.VisitedLinkColor = Primary;
                    linkCol.TrackVisitedState = false;
                }
            }
        }

        public static void StylePictureBox(PictureBox pb, Color borderColor, int borderSize, int cornerRadius)
        {
            pb.BackColor = Color.White;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            pb.Paint += (s, e) =>
            {
                var rect = pb.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = GetRoundedPath(rect, cornerRadius))
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    pb.Region = new Region(path);
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
