namespace Ziare
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Afisare = new System.Windows.Forms.ToolStripMenuItem();
            this.ziareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redacțiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.Panel();
            this.abonamenteDataSet8 = new Ziare.AbonamenteDataSet8();
            this.redactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redactiiTableAdapter = new Ziare.AbonamenteDataSet8TableAdapters.RedactiiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bothbutton = new System.Windows.Forms.RadioButton();
            this.Rubutton = new System.Windows.Forms.RadioButton();
            this.Mdbutton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Afisare,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // Afisare
            // 
            this.Afisare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ziareToolStripMenuItem,
            this.redacțiiToolStripMenuItem});
            this.Afisare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Afisare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Afisare.Name = "Afisare";
            this.Afisare.Size = new System.Drawing.Size(68, 21);
            this.Afisare.Text = "Afișează";
            // 
            // ziareToolStripMenuItem
            // 
            this.ziareToolStripMenuItem.Name = "ziareToolStripMenuItem";
            this.ziareToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ziareToolStripMenuItem.Text = "Ziare";
            this.ziareToolStripMenuItem.Click += new System.EventHandler(this.ziareToolStripMenuItem_Click);
            // 
            // redacțiiToolStripMenuItem
            // 
            this.redacțiiToolStripMenuItem.Name = "redacțiiToolStripMenuItem";
            this.redacțiiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redacțiiToolStripMenuItem.Text = "Redacții";
            this.redacțiiToolStripMenuItem.Click += new System.EventHandler(this.redacțiiToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.exportToolStripMenuItem.Text = "Export (Excel)";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseMenu.Location = new System.Drawing.Point(770, 0);
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(30, 30);
            this.CloseMenu.TabIndex = 4;
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            this.CloseMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseMenu_Paint);
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(728, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(36, 30);
            this.Min.TabIndex = 5;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            this.Min.Paint += new System.Windows.Forms.PaintEventHandler(this.Min_Paint);
            // 
            // abonamenteDataSet8
            // 
            this.abonamenteDataSet8.DataSetName = "AbonamenteDataSet8";
            this.abonamenteDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redactiiBindingSource
            // 
            this.redactiiBindingSource.DataMember = "Redactii";
            this.redactiiBindingSource.DataSource = this.abonamenteDataSet8;
            // 
            // redactiiTableAdapter
            // 
            this.redactiiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(721, 155);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bothbutton);
            this.panel1.Controls.Add(this.Rubutton);
            this.panel1.Controls.Add(this.Mdbutton);
            this.panel1.Location = new System.Drawing.Point(158, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 49);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // bothbutton
            // 
            this.bothbutton.AutoSize = true;
            this.bothbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.bothbutton.Location = new System.Drawing.Point(367, 16);
            this.bothbutton.Name = "bothbutton";
            this.bothbutton.Size = new System.Drawing.Size(60, 17);
            this.bothbutton.TabIndex = 2;
            this.bothbutton.TabStop = true;
            this.bothbutton.Text = "Ambele";
            this.bothbutton.UseVisualStyleBackColor = true;
            this.bothbutton.Click += new System.EventHandler(this.bothbutton_Click);
            // 
            // Rubutton
            // 
            this.Rubutton.AutoSize = true;
            this.Rubutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Rubutton.Location = new System.Drawing.Point(216, 16);
            this.Rubutton.Name = "Rubutton";
            this.Rubutton.Size = new System.Drawing.Size(41, 17);
            this.Rubutton.TabIndex = 1;
            this.Rubutton.TabStop = true;
            this.Rubutton.Text = "RU";
            this.Rubutton.UseVisualStyleBackColor = true;
            this.Rubutton.Click += new System.EventHandler(this.Rubutton_Click);
            // 
            // Mdbutton
            // 
            this.Mdbutton.AutoSize = true;
            this.Mdbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Mdbutton.Location = new System.Drawing.Point(23, 16);
            this.Mdbutton.Name = "Mdbutton";
            this.Mdbutton.Size = new System.Drawing.Size(42, 17);
            this.Mdbutton.TabIndex = 0;
            this.Mdbutton.TabStop = true;
            this.Mdbutton.Text = "MD";
            this.Mdbutton.UseVisualStyleBackColor = true;
            this.Mdbutton.Click += new System.EventHandler(this.Mdbutton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.CloseMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Ziare";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonamenteDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Afisare;
        private System.Windows.Forms.Panel CloseMenu;
        private System.Windows.Forms.Panel Min;
        private AbonamenteDataSet8 abonamenteDataSet8;
        private System.Windows.Forms.BindingSource redactiiBindingSource;
        private AbonamenteDataSet8TableAdapters.RedactiiTableAdapter redactiiTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem ziareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redacțiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton bothbutton;
        private System.Windows.Forms.RadioButton Rubutton;
        private System.Windows.Forms.RadioButton Mdbutton;
    }
}