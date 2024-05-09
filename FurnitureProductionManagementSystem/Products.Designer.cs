namespace FurnitureProductionManagementSystem
{
    partial class Product
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
            label1 = new Label();
            pntbl = new TextBox();
            ptbl = new TextBox();
            qtbl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            sbtn = new Button();
            resetbtn = new Button();
            ubtn = new Button();
            dbtn = new Button();
            pDGV = new DataGridView();
            restorebtn = new Button();
            label4 = new Label();
            label5 = new Label();
            stbl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 87);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // pntbl
            // 
            pntbl.Location = new Point(108, 115);
            pntbl.Name = "pntbl";
            pntbl.Size = new Size(207, 31);
            pntbl.TabIndex = 1;
            // 
            // ptbl
            // 
            ptbl.Location = new Point(619, 115);
            ptbl.Name = "ptbl";
            ptbl.Size = new Size(207, 31);
            ptbl.TabIndex = 2;
            // 
            // qtbl
            // 
            qtbl.Location = new Point(364, 115);
            qtbl.Name = "qtbl";
            qtbl.Size = new Size(207, 31);
            qtbl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 87);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 87);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Location = new Point(108, 200);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 6;
            sbtn.Text = "Save";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Location = new Point(679, 200);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(147, 42);
            resetbtn.TabIndex = 7;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Location = new Point(290, 200);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(147, 42);
            ubtn.TabIndex = 7;
            ubtn.Text = "Update";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(484, 200);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(147, 42);
            dbtn.TabIndex = 8;
            dbtn.Text = "Delete";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // pDGV
            // 
            pDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDGV.Dock = DockStyle.Bottom;
            pDGV.Location = new Point(0, 385);
            pDGV.Name = "pDGV";
            pDGV.RowHeadersWidth = 51;
            pDGV.Size = new Size(881, 309);
            pDGV.TabIndex = 9;
            pDGV.CellContentClick += pDGV_CellContentClick;
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(679, 340);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 10;
            restorebtn.Text = "Restore";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 11;
            label4.Text = "Products List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 348);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 12;
            label5.Text = "Search by All Types";
            // 
            // stbl
            // 
            stbl.Location = new Point(364, 345);
            stbl.Name = "stbl";
            stbl.Size = new Size(285, 31);
            stbl.TabIndex = 13;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(stbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(restorebtn);
            Controls.Add(pDGV);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(resetbtn);
            Controls.Add(sbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(qtbl);
            Controls.Add(ptbl);
            Controls.Add(pntbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pntbl;
        private TextBox ptbl;
        private TextBox qtbl;
        private Label label2;
        private Label label3;
        private Button sbtn;
        private Button resetbtn;
        private Button ubtn;
        private Button dbtn;
        private DataGridView pDGV;
        private Button restorebtn;
        private Label label4;
        private Label label5;
        private TextBox stbl;
    }
}