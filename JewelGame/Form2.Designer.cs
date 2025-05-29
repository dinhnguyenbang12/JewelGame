namespace JewelGame
{
    partial class formMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd1nguoi = new System.Windows.Forms.RadioButton();
            this.rd2nguoi = new System.Windows.Forms.RadioButton();
            this.cbKichCo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTenNgChoi = new System.Windows.Forms.Label();
            this.txtTenNgChoi = new System.Windows.Forms.TextBox();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbNgChoi1 = new System.Windows.Forms.Label();
            this.lbNgChoi2 = new System.Windows.Forms.Label();
            this.txtNgChoi2 = new System.Windows.Forms.TextBox();
            this.txtNgChoi1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chế độ chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kích cỡ";
            // 
            // rd1nguoi
            // 
            this.rd1nguoi.AutoSize = true;
            this.rd1nguoi.Checked = true;
            this.rd1nguoi.Location = new System.Drawing.Point(118, 3);
            this.rd1nguoi.Name = "rd1nguoi";
            this.rd1nguoi.Size = new System.Drawing.Size(102, 20);
            this.rd1nguoi.TabIndex = 2;
            this.rd1nguoi.TabStop = true;
            this.rd1nguoi.Text = "1 người chơi ";
            this.rd1nguoi.UseVisualStyleBackColor = true;
            this.rd1nguoi.CheckedChanged += new System.EventHandler(this.rd1nguoi_CheckedChanged);
            // 
            // rd2nguoi
            // 
            this.rd2nguoi.AutoSize = true;
            this.rd2nguoi.Location = new System.Drawing.Point(118, 30);
            this.rd2nguoi.Name = "rd2nguoi";
            this.rd2nguoi.Size = new System.Drawing.Size(102, 20);
            this.rd2nguoi.TabIndex = 3;
            this.rd2nguoi.Text = "2 người chơi ";
            this.rd2nguoi.UseVisualStyleBackColor = true;
            this.rd2nguoi.CheckedChanged += new System.EventHandler(this.rd2nguoi_CheckedChanged);
            // 
            // cbKichCo
            // 
            this.cbKichCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKichCo.FormattingEnabled = true;
            this.cbKichCo.Items.AddRange(new object[] {
            "8x8",
            "10x10",
            "12x12"});
            this.cbKichCo.Location = new System.Drawing.Point(118, 71);
            this.cbKichCo.Name = "cbKichCo";
            this.cbKichCo.Size = new System.Drawing.Size(165, 24);
            this.cbKichCo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbKichCo);
            this.panel1.Controls.Add(this.rd1nguoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rd2nguoi);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 112);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.txtNgChoi1);
            this.panel2.Controls.Add(this.txtNgChoi2);
            this.panel2.Controls.Add(this.lbNgChoi2);
            this.panel2.Controls.Add(this.btnBatDau);
            this.panel2.Controls.Add(this.lbNgChoi1);
            this.panel2.Controls.Add(this.txtTenNgChoi);
            this.panel2.Controls.Add(this.lbTenNgChoi);
            this.panel2.Location = new System.Drawing.Point(321, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 112);
            this.panel2.TabIndex = 6;
            // 
            // lbTenNgChoi
            // 
            this.lbTenNgChoi.AutoSize = true;
            this.lbTenNgChoi.Location = new System.Drawing.Point(3, 8);
            this.lbTenNgChoi.Name = "lbTenNgChoi";
            this.lbTenNgChoi.Size = new System.Drawing.Size(95, 16);
            this.lbTenNgChoi.TabIndex = 7;
            this.lbTenNgChoi.Text = "Tên người chơi";
            // 
            // txtTenNgChoi
            // 
            this.txtTenNgChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNgChoi.Location = new System.Drawing.Point(166, 5);
            this.txtTenNgChoi.Name = "txtTenNgChoi";
            this.txtTenNgChoi.Size = new System.Drawing.Size(235, 22);
            this.txtTenNgChoi.TabIndex = 8;
            // 
            // btnBatDau
            // 
            this.btnBatDau.AutoSize = true;
            this.btnBatDau.Location = new System.Drawing.Point(166, 63);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(122, 39);
            this.btnBatDau.TabIndex = 9;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv1.Location = new System.Drawing.Point(12, 197);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(776, 241);
            this.dgv1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stt";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Người Chơi 1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Người Chơi 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(335, 145);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 46);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Lịch sử ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbNgChoi1
            // 
            this.lbNgChoi1.AutoSize = true;
            this.lbNgChoi1.Location = new System.Drawing.Point(3, 14);
            this.lbNgChoi1.Name = "lbNgChoi1";
            this.lbNgChoi1.Size = new System.Drawing.Size(84, 16);
            this.lbNgChoi1.TabIndex = 9;
            this.lbNgChoi1.Text = "Người chơi 1 ";
            // 
            // lbNgChoi2
            // 
            this.lbNgChoi2.AutoSize = true;
            this.lbNgChoi2.Location = new System.Drawing.Point(3, 36);
            this.lbNgChoi2.Name = "lbNgChoi2";
            this.lbNgChoi2.Size = new System.Drawing.Size(84, 16);
            this.lbNgChoi2.TabIndex = 10;
            this.lbNgChoi2.Text = "Người chơi 2 ";
            // 
            // txtNgChoi2
            // 
            this.txtNgChoi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgChoi2.Location = new System.Drawing.Point(166, 36);
            this.txtNgChoi2.Name = "txtNgChoi2";
            this.txtNgChoi2.Size = new System.Drawing.Size(235, 22);
            this.txtNgChoi2.TabIndex = 11;
            // 
            // txtNgChoi1
            // 
            this.txtNgChoi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgChoi1.Location = new System.Drawing.Point(166, 11);
            this.txtNgChoi1.Name = "txtNgChoi1";
            this.txtNgChoi1.Size = new System.Drawing.Size(235, 22);
            this.txtNgChoi1.TabIndex = 12;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formMenu";
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd1nguoi;
        private System.Windows.Forms.RadioButton rd2nguoi;
        private System.Windows.Forms.ComboBox cbKichCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.TextBox txtTenNgChoi;
        private System.Windows.Forms.Label lbTenNgChoi;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbNgChoi1;
        private System.Windows.Forms.TextBox txtNgChoi1;
        private System.Windows.Forms.TextBox txtNgChoi2;
        private System.Windows.Forms.Label lbNgChoi2;
    }
}