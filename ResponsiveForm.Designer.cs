namespace BT4_5_ResponsiveForm
{
    partial class ResponsiveForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableMain   = new System.Windows.Forms.TableLayoutPanel();
            grpInput    = new System.Windows.Forms.GroupBox();
            lblName     = new System.Windows.Forms.Label();
            txtName     = new System.Windows.Forms.TextBox();
            lblEmail    = new System.Windows.Forms.Label();
            txtEmail    = new System.Windows.Forms.TextBox();
            lblPhone    = new System.Windows.Forms.Label();
            txtPhone    = new System.Windows.Forms.TextBox();
            pnlRight    = new System.Windows.Forms.Panel();
            dgvData     = new System.Windows.Forms.DataGridView();
            pnlButtons  = new System.Windows.Forms.Panel();
            btnAdd      = new System.Windows.Forms.Button();
            btnDelete   = new System.Windows.Forms.Button();
            btnClear    = new System.Windows.Forms.Button();
            lblTitle    = new System.Windows.Forms.Label();

            tableMain.SuspendLayout();
            grpInput.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // Form
            Text          = "Quản Lý Danh Sách - Responsive";
            Size          = new System.Drawing.Size(900, 560);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MinimumSize   = new System.Drawing.Size(700, 450);

            // tableMain (Dock = Fill, 2 cột: 30% & 70%)
            tableMain.Dock        = System.Windows.Forms.DockStyle.Fill;
            tableMain.ColumnCount = 2;
            tableMain.RowCount    = 2;
            tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // lblTitle – span 2 cột
            lblTitle.Text      = "📋  QUẢN LÝ DANH SÁCH";
            lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            tableMain.SetColumnSpan(lblTitle, 2);
            tableMain.Controls.Add(lblTitle, 0, 0);

            // Cột 1 (30%) - GroupBox nhập liệu
            grpInput.Text = "Thông Tin";
            grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            grpInput.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);

            int row = 30, gap = 50;
            lblName.Text      = "Họ Tên:";
            lblName.Location  = new System.Drawing.Point(10, row);
            lblName.Size      = new System.Drawing.Size(60, 23);
            txtName.Location  = new System.Drawing.Point(10, row + 22);
            txtName.Size      = new System.Drawing.Size(220, 23);
            txtName.Anchor    = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            row += gap;

            lblEmail.Text      = "Email:";
            lblEmail.Location  = new System.Drawing.Point(10, row);
            lblEmail.Size      = new System.Drawing.Size(60, 23);
            txtEmail.Location  = new System.Drawing.Point(10, row + 22);
            txtEmail.Size      = new System.Drawing.Size(220, 23);
            txtEmail.Anchor    = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            row += gap;

            lblPhone.Text      = "Điện Thoại:";
            lblPhone.Location  = new System.Drawing.Point(10, row);
            lblPhone.Size      = new System.Drawing.Size(90, 23);
            txtPhone.Location  = new System.Drawing.Point(10, row + 22);
            txtPhone.Size      = new System.Drawing.Size(220, 23);
            txtPhone.Anchor    = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            grpInput.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblName, txtName, lblEmail, txtEmail, lblPhone, txtPhone
            });
            tableMain.Controls.Add(grpInput, 0, 1);

            // Cột 2 (70%) - Panel chứa DataGridView + nút bấm
            pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // DataGridView
            dgvData.Dock              = System.Windows.Forms.DockStyle.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly          = true;
            dgvData.SelectionMode     = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BorderStyle       = System.Windows.Forms.BorderStyle.None;

            // pnlButtons – Anchor = Bottom, Right để co giãn theo cửa sổ
            pnlButtons.Height = 50;
            pnlButtons.Dock   = System.Windows.Forms.DockStyle.Bottom;

            btnAdd.Text      = "➕ Thêm";
            btnAdd.Size      = new System.Drawing.Size(100, 36);
            btnAdd.Location  = new System.Drawing.Point(0, 7);
            btnAdd.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Click    += btnAdd_Click;

            btnDelete.Text      = "🗑 Xóa";
            btnDelete.Size      = new System.Drawing.Size(100, 36);
            btnDelete.Location  = new System.Drawing.Point(110, 7);
            btnDelete.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Click    += btnDelete_Click;

            btnClear.Text      = "🧹 Xóa Form";
            btnClear.Size      = new System.Drawing.Size(110, 36);
            btnClear.Location  = new System.Drawing.Point(220, 7);
            btnClear.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClear.BackColor = System.Drawing.Color.FromArgb(100, 100, 150);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Click    += btnClear_Click;

            pnlButtons.Controls.AddRange(new System.Windows.Forms.Control[] { btnAdd, btnDelete, btnClear });
            pnlRight.Controls.AddRange(new System.Windows.Forms.Control[] { dgvData, pnlButtons });
            tableMain.Controls.Add(pnlRight, 1, 1);

            tableMain.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlButtons.ResumeLayout(false);

            Controls.Add(tableMain);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label            lblTitle;
        private System.Windows.Forms.GroupBox         grpInput;
        private System.Windows.Forms.Label            lblName, lblEmail, lblPhone;
        private System.Windows.Forms.TextBox          txtName, txtEmail, txtPhone;
        private System.Windows.Forms.Panel            pnlRight, pnlButtons;
        private System.Windows.Forms.DataGridView     dgvData;
        private System.Windows.Forms.Button           btnAdd, btnDelete, btnClear;
    }
}
