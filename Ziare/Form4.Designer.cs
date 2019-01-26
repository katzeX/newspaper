namespace Ziare
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abonațiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Salveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.Exclude = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamenteConformLuniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.redactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonamenteDataSet5 = new Ziare.AbonamenteDataSet5();
            this.redactiiTableAdapter = new Ziare.AbonamenteDataSet5TableAdapters.RedactiiTableAdapter();
            this.abonamenteDataSet = new Ziare.AbonamenteDataSet();
            this.abonamenteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.lookForMonth = new System.Windows.Forms.Button();
            this.viewAb = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonațiiToolStripMenuItem,
            this.Salveaza,
            this.Exclude,
            this.afișeazăToolStripMenuItem,
            this.abonamenteConformLuniiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(799, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // abonațiiToolStripMenuItem
            // 
            this.abonațiiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonațiiToolStripMenuItem.Name = "abonațiiToolStripMenuItem";
            this.abonațiiToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.abonațiiToolStripMenuItem.Text = "Abonații";
            this.abonațiiToolStripMenuItem.Click += new System.EventHandler(this.abonațiiToolStripMenuItem_Click);
            // 
            // Salveaza
            // 
            this.Salveaza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salveaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Salveaza.Name = "Salveaza";
            this.Salveaza.Size = new System.Drawing.Size(124, 21);
            this.Salveaza.Text = "Ziarele abonatului";
            this.Salveaza.Click += new System.EventHandler(this.Salveaza_Click);
            // 
            // Exclude
            // 
            this.Exclude.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exclude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Exclude.Name = "Exclude";
            this.Exclude.Size = new System.Drawing.Size(117, 21);
            this.Exclude.Text = "Numărul de ziare";
            this.Exclude.Click += new System.EventHandler(this.Exclude_Click);
            // 
            // afișeazăToolStripMenuItem
            // 
            this.afișeazăToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afișeazăToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.afișeazăToolStripMenuItem.Name = "afișeazăToolStripMenuItem";
            this.afișeazăToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.afișeazăToolStripMenuItem.Text = "Preț";
            this.afișeazăToolStripMenuItem.Click += new System.EventHandler(this.afișeazăToolStripMenuItem_Click);
            // 
            // abonamenteConformLuniiToolStripMenuItem
            // 
            this.abonamenteConformLuniiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonamenteConformLuniiToolStripMenuItem.Name = "abonamenteConformLuniiToolStripMenuItem";
            this.abonamenteConformLuniiToolStripMenuItem.Size = new System.Drawing.Size(163, 21);
            this.abonamenteConformLuniiToolStripMenuItem.Text = "Abonamente conform lunii";
            this.abonamenteConformLuniiToolStripMenuItem.Click += new System.EventHandler(this.abonamenteConformLuniiToolStripMenuItem_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseMenu.Location = new System.Drawing.Point(769, 0);
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(30, 30);
            this.CloseMenu.TabIndex = 4;
            this.CloseMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseMenu_Paint);
            this.CloseMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseMenu_MouseClick);
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(727, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(36, 30);
            this.Min.TabIndex = 6;
            this.Min.Paint += new System.Windows.Forms.PaintEventHandler(this.Min_Paint);
            this.Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Min_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 218);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.redactiiBindingSource;
            this.comboBox1.DisplayMember = "DenRedactie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "idRed";
            // 
            // redactiiBindingSource
            // 
            this.redactiiBindingSource.DataMember = "Redactii";
            this.redactiiBindingSource.DataSource = this.abonamenteDataSet5;
            // 
            // abonamenteDataSet5
            // 
            this.abonamenteDataSet5.DataSetName = "AbonamenteDataSet5";
            this.abonamenteDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redactiiTableAdapter
            // 
            this.redactiiTableAdapter.ClearBeforeFill = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.button1.Location = new System.Drawing.Point(337, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Numărul de ziare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthBox.Location = new System.Drawing.Point(162, 71);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(163, 21);
            this.monthBox.TabIndex = 13;
            this.monthBox.Visible = false;
            // 
            // priceButton
            // 
            this.priceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.priceButton.Location = new System.Drawing.Point(337, 105);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(126, 27);
            this.priceButton.TabIndex = 14;
            this.priceButton.Text = "Preț";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Visible = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // lookForMonth
            // 
            this.lookForMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lookForMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookForMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.lookForMonth.Location = new System.Drawing.Point(452, 71);
            this.lookForMonth.Name = "lookForMonth";
            this.lookForMonth.Size = new System.Drawing.Size(126, 27);
            this.lookForMonth.TabIndex = 16;
            this.lookForMonth.Text = "Caută";
            this.lookForMonth.UseVisualStyleBackColor = true;
            this.lookForMonth.Visible = false;
            this.lookForMonth.Click += new System.EventHandler(this.lookForMonth_Click);
            // 
            // viewAb
            // 
            this.viewAb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewAb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.viewAb.Location = new System.Drawing.Point(637, 65);
            this.viewAb.Name = "viewAb";
            this.viewAb.Size = new System.Drawing.Size(126, 27);
            this.viewAb.TabIndex = 17;
            this.viewAb.Text = "Vizualizează";
            this.viewAb.UseVisualStyleBackColor = true;
            this.viewAb.Visible = false;
            this.viewAb.Click += new System.EventHandler(this.viewAb_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(799, 379);
            this.Controls.Add(this.viewAb);
            this.Controls.Add(this.lookForMonth);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.CloseMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Date";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Salveaza;
        private System.Windows.Forms.ToolStripMenuItem Exclude;
        private System.Windows.Forms.ToolStripMenuItem afișeazăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamenteConformLuniiToolStripMenuItem;
        private System.Windows.Forms.Panel CloseMenu;
        private System.Windows.Forms.Panel Min;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private AbonamenteDataSet5 abonamenteDataSet5;
        private System.Windows.Forms.BindingSource redactiiBindingSource;
        private AbonamenteDataSet5TableAdapters.RedactiiTableAdapter redactiiTableAdapter;
        private AbonamenteDataSet abonamenteDataSet;
        private System.Windows.Forms.BindingSource abonamenteDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem abonațiiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button lookForMonth;
        private System.Windows.Forms.Button viewAb;
    }
}