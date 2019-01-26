namespace Ziare
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.determinăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonațiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ziareȘiRedacțiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.General = new System.Windows.Forms.Button();
            this.Sanatate = new System.Windows.Forms.Button();
            this.Social = new System.Windows.Forms.Button();
            this.Educatie = new System.Windows.Forms.Button();
            this.Cultura = new System.Windows.Forms.Button();
            this.Culinarie = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(836, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăToolStripMenuItem,
            this.determinăToolStripMenuItem,
            this.ieșireToolStripMenuItem});
            this.fișierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fișierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.fișierToolStripMenuItem.Text = "Fișier";
            // 
            // adaugăToolStripMenuItem
            // 
            this.adaugăToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adaugăToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonatToolStripMenuItem,
            this.abonamentToolStripMenuItem});
            this.adaugăToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.adaugăToolStripMenuItem.Name = "adaugăToolStripMenuItem";
            this.adaugăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugăToolStripMenuItem.Text = "Adaugă";
            // 
            // abonatToolStripMenuItem
            // 
            this.abonatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.abonatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonatToolStripMenuItem.Name = "abonatToolStripMenuItem";
            this.abonatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonatToolStripMenuItem.Text = "Abonat";
            this.abonatToolStripMenuItem.Click += new System.EventHandler(this.abonatToolStripMenuItem_Click);
            // 
            // abonamentToolStripMenuItem
            // 
            this.abonamentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.abonamentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonamentToolStripMenuItem.Name = "abonamentToolStripMenuItem";
            this.abonamentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonamentToolStripMenuItem.Text = "Abonament";
            this.abonamentToolStripMenuItem.Click += new System.EventHandler(this.abonamentToolStripMenuItem_Click);
            // 
            // determinăToolStripMenuItem
            // 
            this.determinăToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.determinăToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.determinăToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.determinăToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.determinăToolStripMenuItem.Name = "determinăToolStripMenuItem";
            this.determinăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.determinăToolStripMenuItem.Text = "Determină";
            this.determinăToolStripMenuItem.Click += new System.EventHandler(this.determinăToolStripMenuItem_Click);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ieșireToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ieșireToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ieșireToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonațiToolStripMenuItem,
            this.abonamenteToolStripMenuItem,
            this.ziareȘiRedacțiiToolStripMenuItem});
            this.dateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // abonațiToolStripMenuItem
            // 
            this.abonațiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.abonațiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonațiToolStripMenuItem.Name = "abonațiToolStripMenuItem";
            this.abonațiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonațiToolStripMenuItem.Text = "Abonați";
            this.abonațiToolStripMenuItem.Click += new System.EventHandler(this.abonațiToolStripMenuItem_Click);
            // 
            // abonamenteToolStripMenuItem
            // 
            this.abonamenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.abonamenteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.abonamenteToolStripMenuItem.Name = "abonamenteToolStripMenuItem";
            this.abonamenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonamenteToolStripMenuItem.Text = "Abonamente";
            this.abonamenteToolStripMenuItem.Click += new System.EventHandler(this.abonamenteToolStripMenuItem_Click);
            // 
            // ziareȘiRedacțiiToolStripMenuItem
            // 
            this.ziareȘiRedacțiiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ziareȘiRedacțiiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ziareȘiRedacțiiToolStripMenuItem.Name = "ziareȘiRedacțiiToolStripMenuItem";
            this.ziareȘiRedacțiiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ziareȘiRedacțiiToolStripMenuItem.Text = "Ziare și Redacții";
            this.ziareȘiRedacțiiToolStripMenuItem.Click += new System.EventHandler(this.ziareȘiRedacțiiToolStripMenuItem_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseMenu.Location = new System.Drawing.Point(806, 0);
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(30, 30);
            this.CloseMenu.TabIndex = 1;
            this.CloseMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseMenu_Paint);
            this.CloseMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseMenu_MouseClick);
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(764, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(36, 30);
            this.Min.TabIndex = 3;
            this.Min.Paint += new System.Windows.Forms.PaintEventHandler(this.Min_Paint);
            this.Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Min_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.General);
            this.panel1.Controls.Add(this.Sanatate);
            this.panel1.Controls.Add(this.Social);
            this.panel1.Controls.Add(this.Educatie);
            this.panel1.Controls.Add(this.Cultura);
            this.panel1.Controls.Add(this.Culinarie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 333);
            this.panel1.TabIndex = 4;
            // 
            // General
            // 
            this.General.FlatAppearance.BorderSize = 0;
            this.General.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.General.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.General.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.General.Location = new System.Drawing.Point(0, 293);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(144, 37);
            this.General.TabIndex = 10;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.Sanatate_Click);
            this.General.MouseLeave += new System.EventHandler(this.General_MouseLeave);
            this.General.MouseHover += new System.EventHandler(this.General_MouseHover);
            // 
            // Sanatate
            // 
            this.Sanatate.FlatAppearance.BorderSize = 0;
            this.Sanatate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sanatate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sanatate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Sanatate.Location = new System.Drawing.Point(0, 241);
            this.Sanatate.Name = "Sanatate";
            this.Sanatate.Size = new System.Drawing.Size(144, 46);
            this.Sanatate.TabIndex = 9;
            this.Sanatate.Text = "Sănătate";
            this.Sanatate.UseVisualStyleBackColor = true;
            this.Sanatate.MouseLeave += new System.EventHandler(this.sleave);
            this.Sanatate.MouseHover += new System.EventHandler(this.Sanatate_MouseHover);
            // 
            // Social
            // 
            this.Social.FlatAppearance.BorderSize = 0;
            this.Social.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Social.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Social.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Social.Location = new System.Drawing.Point(0, 193);
            this.Social.Name = "Social";
            this.Social.Size = new System.Drawing.Size(144, 42);
            this.Social.TabIndex = 8;
            this.Social.Text = "Social";
            this.Social.UseVisualStyleBackColor = true;
            this.Social.MouseLeave += new System.EventHandler(this.Social_MouseLeave);
            this.Social.MouseHover += new System.EventHandler(this.Social_MouseHover);
            // 
            // Educatie
            // 
            this.Educatie.FlatAppearance.BorderSize = 0;
            this.Educatie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Educatie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Educatie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Educatie.Location = new System.Drawing.Point(0, 134);
            this.Educatie.Name = "Educatie";
            this.Educatie.Size = new System.Drawing.Size(144, 37);
            this.Educatie.TabIndex = 7;
            this.Educatie.Text = "Educație";
            this.Educatie.UseVisualStyleBackColor = true;
            this.Educatie.MouseLeave += new System.EventHandler(this.Educatie_MouseLeave);
            this.Educatie.MouseHover += new System.EventHandler(this.Educatie_MouseHover);
            // 
            // Cultura
            // 
            this.Cultura.FlatAppearance.BorderSize = 0;
            this.Cultura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cultura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cultura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Cultura.Location = new System.Drawing.Point(0, 78);
            this.Cultura.Name = "Cultura";
            this.Cultura.Size = new System.Drawing.Size(144, 33);
            this.Cultura.TabIndex = 6;
            this.Cultura.Text = "Cultură";
            this.Cultura.UseVisualStyleBackColor = true;
            this.Cultura.MouseLeave += new System.EventHandler(this.Cultura_MouseLeave);
            this.Cultura.MouseHover += new System.EventHandler(this.Cultura_MouseHover);
            // 
            // Culinarie
            // 
            this.Culinarie.FlatAppearance.BorderSize = 0;
            this.Culinarie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Culinarie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Culinarie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.Culinarie.Location = new System.Drawing.Point(0, 29);
            this.Culinarie.Name = "Culinarie";
            this.Culinarie.Size = new System.Drawing.Size(144, 32);
            this.Culinarie.TabIndex = 5;
            this.Culinarie.Text = "Culinarie";
            this.Culinarie.UseVisualStyleBackColor = true;
            this.Culinarie.MouseLeave += new System.EventHandler(this.Culinarie_MouseLeave);
            this.Culinarie.MouseHover += new System.EventHandler(this.Culinarie_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Ziare.Properties.Resources.adevarul;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(651, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 210);
            this.panel4.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Ziare.Properties.Resources.culinaria;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(484, 91);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(149, 210);
            this.panel7.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Ziare.Properties.Resources.recipes;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(320, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 210);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ziare.Properties.Resources.makler;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(150, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 210);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(836, 364);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.CloseMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Abonamente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem determinăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonațiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ziareȘiRedacțiiToolStripMenuItem;
        private System.Windows.Forms.Panel CloseMenu;
        private System.Windows.Forms.Panel Min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Culinarie;
        private System.Windows.Forms.Button General;
        private System.Windows.Forms.Button Sanatate;
        private System.Windows.Forms.Button Social;
        private System.Windows.Forms.Button Educatie;
        private System.Windows.Forms.Button Cultura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
    }
}

