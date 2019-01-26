namespace Ziare
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exclude = new System.Windows.Forms.ToolStripMenuItem();
            this.Afisare = new System.Windows.Forms.ToolStripMenuItem();
            this.Min = new System.Windows.Forms.Panel();
            this.CloseMenu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.abBox = new System.Windows.Forms.ComboBox();
            this.abonatiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonamenteDataSet6 = new Ziare.AbonamenteDataSet6();
            this.abonamenteDataSet = new Ziare.AbonamenteDataSet();
            this.abonamenteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonatiiTableAdapter = new Ziare.AbonamenteDataSet6TableAdapters.AbonatiiTableAdapter();
            this.ziarBox = new System.Windows.Forms.ComboBox();
            this.ziareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonamenteDataSet7 = new Ziare.AbonamenteDataSet7();
            this.ziareTableAdapter = new Ziare.AbonamenteDataSet7TableAdapters.ZiareTableAdapter();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonatiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ziareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem,
            this.Exclude,
            this.Afisare});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(813, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fișierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.fișierToolStripMenuItem.Text = "Salvează";
            this.fișierToolStripMenuItem.Click += new System.EventHandler(this.fișierToolStripMenuItem_Click);
            // 
            // Exclude
            // 
            this.Exclude.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exclude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Exclude.Name = "Exclude";
            this.Exclude.Size = new System.Drawing.Size(63, 21);
            this.Exclude.Text = "Exclude";
            this.Exclude.ToolTipText = "Înainte de a șterge un abonament, alege din lista celor existenți! (Click Afișeaz" +
    "ă)";
            this.Exclude.Click += new System.EventHandler(this.Exclude_Click);
            // 
            // Afisare
            // 
            this.Afisare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Afisare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Afisare.Name = "Afisare";
            this.Afisare.Size = new System.Drawing.Size(68, 21);
            this.Afisare.Text = "Afișează";
            this.Afisare.Click += new System.EventHandler(this.Afisare_Click);
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(741, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(36, 30);
            this.Min.TabIndex = 5;
            this.Min.Paint += new System.Windows.Forms.PaintEventHandler(this.Min_Paint);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseMenu.Location = new System.Drawing.Point(783, 0);
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(30, 30);
            this.CloseMenu.TabIndex = 6;
            this.CloseMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseMenu_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Realizare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Abonat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(51, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Ziar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(481, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data început";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(481, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data sfârșit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(470, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Suma spre achitare";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBox1, "ID -ul este format din 3 litere de tipar și 3 cifre!");
            // 
            // abBox
            // 
            this.abBox.DataSource = this.abonatiiBindingSource;
            this.abBox.DisplayMember = "idAbonat";
            this.abBox.FormattingEnabled = true;
            this.abBox.Location = new System.Drawing.Point(155, 139);
            this.abBox.Name = "abBox";
            this.abBox.Size = new System.Drawing.Size(147, 21);
            this.abBox.TabIndex = 16;
            this.abBox.ValueMember = "idAbonat";
            // 
            // abonatiiBindingSource
            // 
            this.abonatiiBindingSource.DataMember = "Abonatii";
            this.abonatiiBindingSource.DataSource = this.abonamenteDataSet6;
            // 
            // abonamenteDataSet6
            // 
            this.abonamenteDataSet6.DataSetName = "AbonamenteDataSet6";
            this.abonamenteDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonamenteDataSet
            // 
            this.abonamenteDataSet.DataSetName = "AbonamenteDataSet";
            this.abonamenteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonamenteDataSetBindingSource
            // 
            this.abonamenteDataSetBindingSource.DataSource = this.abonamenteDataSet;
            this.abonamenteDataSetBindingSource.Position = 0;
            // 
            // abonatiiTableAdapter
            // 
            this.abonatiiTableAdapter.ClearBeforeFill = true;
            // 
            // ziarBox
            // 
            this.ziarBox.DataSource = this.ziareBindingSource;
            this.ziarBox.DisplayMember = "DenZiar";
            this.ziarBox.FormattingEnabled = true;
            this.ziarBox.Location = new System.Drawing.Point(155, 195);
            this.ziarBox.Name = "ziarBox";
            this.ziarBox.Size = new System.Drawing.Size(147, 21);
            this.ziarBox.TabIndex = 17;
            this.ziarBox.ValueMember = "idZiar";
            // 
            // ziareBindingSource
            // 
            this.ziareBindingSource.DataMember = "Ziare";
            this.ziareBindingSource.DataSource = this.abonamenteDataSet7;
            // 
            // abonamenteDataSet7
            // 
            this.abonamenteDataSet7.DataSetName = "AbonamenteDataSet7";
            this.abonamenteDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ziareTableAdapter
            // 
            this.ziareTableAdapter.ClearBeforeFill = true;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(617, 192);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(147, 20);
            this.priceBox.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(576, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(576, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(813, 429);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.ziarBox);
            this.Controls.Add(this.abBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseMenu);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Abonamente";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonatiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ziareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exclude;
        private System.Windows.Forms.ToolStripMenuItem Afisare;
        private System.Windows.Forms.Panel Min;
        private System.Windows.Forms.Panel CloseMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox abBox;
        private System.Windows.Forms.BindingSource abonamenteDataSetBindingSource;
        private AbonamenteDataSet abonamenteDataSet;
        private AbonamenteDataSet6 abonamenteDataSet6;
        private System.Windows.Forms.BindingSource abonatiiBindingSource;
        private AbonamenteDataSet6TableAdapters.AbonatiiTableAdapter abonatiiTableAdapter;
        private System.Windows.Forms.ComboBox ziarBox;
        private AbonamenteDataSet7 abonamenteDataSet7;
        private System.Windows.Forms.BindingSource ziareBindingSource;
        private AbonamenteDataSet7TableAdapters.ZiareTableAdapter ziareTableAdapter;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}