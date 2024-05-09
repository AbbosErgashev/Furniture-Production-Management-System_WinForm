namespace FurnitureProductionManagementSystem
{
    partial class Production
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
            stbl = new TextBox();
            label5 = new Label();
            label4 = new Label();
            restorebtn = new Button();
            pDGV = new DataGridView();
            dbtn = new Button();
            ubtn = new Button();
            resetbtn = new Button();
            sbtn = new Button();
            atbl = new Label();
            citbl = new Label();
            qptbl = new TextBox();
            label1 = new Label();
            pcb = new ComboBox();
            dtp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pDGV).BeginInit();
            SuspendLayout();
            // 
            // stbl
            // 
            stbl.Location = new Point(364, 339);
            stbl.Name = "stbl";
            stbl.Size = new Size(285, 31);
            stbl.TabIndex = 43;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 342);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 42;
            label5.Text = "Search by All Types";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 341);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 41;
            label4.Text = "Productions List";
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(667, 334);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 40;
            restorebtn.Text = "Restore";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // pDGV
            // 
            pDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDGV.Dock = DockStyle.Bottom;
            pDGV.Location = new Point(0, 379);
            pDGV.Name = "pDGV";
            pDGV.RowHeadersWidth = 51;
            pDGV.Size = new Size(881, 315);
            pDGV.TabIndex = 39;
            pDGV.CellContentClick += pDGV_CellContentClick;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(472, 220);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(147, 42);
            dbtn.TabIndex = 38;
            dbtn.Text = "Delete";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Location = new Point(278, 220);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(147, 42);
            ubtn.TabIndex = 36;
            ubtn.Text = "Update";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Location = new Point(667, 220);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(147, 42);
            resetbtn.TabIndex = 37;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Location = new Point(96, 220);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 35;
            sbtn.Text = "Save";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // atbl
            // 
            atbl.AutoSize = true;
            atbl.Location = new Point(607, 96);
            atbl.Name = "atbl";
            atbl.Size = new Size(141, 25);
            atbl.TabIndex = 34;
            atbl.Text = "Production Date";
            // 
            // citbl
            // 
            citbl.AutoSize = true;
            citbl.Location = new Point(352, 96);
            citbl.Name = "citbl";
            citbl.Size = new Size(161, 25);
            citbl.TabIndex = 33;
            citbl.Text = "Quantity Produced";
            // 
            // qptbl
            // 
            qptbl.Location = new Point(352, 124);
            qptbl.Name = "qptbl";
            qptbl.Size = new Size(207, 31);
            qptbl.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 96);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 29;
            label1.Text = "Product Name";
            // 
            // pcb
            // 
            pcb.FormattingEnabled = true;
            pcb.Location = new Point(96, 124);
            pcb.Name = "pcb";
            pcb.Size = new Size(205, 33);
            pcb.TabIndex = 44;
            // 
            // dtp
            // 
            dtp.Location = new Point(607, 122);
            dtp.Name = "dtp";
            dtp.Size = new Size(207, 31);
            dtp.TabIndex = 45;
            // 
            // Production
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(dtp);
            Controls.Add(pcb);
            Controls.Add(stbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(restorebtn);
            Controls.Add(pDGV);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(resetbtn);
            Controls.Add(sbtn);
            Controls.Add(atbl);
            Controls.Add(citbl);
            Controls.Add(qptbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Production";
            Text = "Production";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stbl;
        private Label label5;
        private Label label4;
        private Button restorebtn;
        private DataGridView pDGV;
        private Button dbtn;
        private Button ubtn;
        private Button resetbtn;
        private Button sbtn;
        private Label atbl;
        private Label citbl;
        private TextBox qptbl;
        private Label label1;
        private ComboBox pcb;
        private DateTimePicker dtp;
    }
}