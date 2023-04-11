
using System;

namespace CatalogStudenti
{
    partial class Meniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.CatalogButtonMeniu = new System.Windows.Forms.Button();
            this.adaugadatelebuton = new System.Windows.Forms.Button();
            this.PanelMeniu = new System.Windows.Forms.Panel();
            this.LogoPanle = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.panelTitleBlock = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.TitleBlockLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMeniu.SuspendLayout();
            this.LogoPanle.SuspendLayout();
            this.panelTitleBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogButtonMeniu
            // 
            this.CatalogButtonMeniu.FlatAppearance.BorderSize = 0;
            this.CatalogButtonMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogButtonMeniu.Font = new System.Drawing.Font("SansSerif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatalogButtonMeniu.ForeColor = System.Drawing.Color.White;
            this.CatalogButtonMeniu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatalogButtonMeniu.Location = new System.Drawing.Point(40, 193);
            this.CatalogButtonMeniu.Name = "CatalogButtonMeniu";
            this.CatalogButtonMeniu.Size = new System.Drawing.Size(198, 92);
            this.CatalogButtonMeniu.TabIndex = 0;
            this.CatalogButtonMeniu.Text = "Catalog";
            this.CatalogButtonMeniu.UseVisualStyleBackColor = false;
            this.CatalogButtonMeniu.Click += new System.EventHandler(this.CatalogClick);
            // 
            // adaugadatelebuton
            // 
            this.adaugadatelebuton.FlatAppearance.BorderSize = 0;
            this.adaugadatelebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugadatelebuton.Font = new System.Drawing.Font("SansSerif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adaugadatelebuton.ForeColor = System.Drawing.Color.White;
            this.adaugadatelebuton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adaugadatelebuton.Location = new System.Drawing.Point(40, 328);
            this.adaugadatelebuton.Name = "adaugadatelebuton";
            this.adaugadatelebuton.Size = new System.Drawing.Size(198, 92);
            this.adaugadatelebuton.TabIndex = 4;
            this.adaugadatelebuton.Text = "Adauga datele";
            this.adaugadatelebuton.UseVisualStyleBackColor = true;
            this.adaugadatelebuton.Click += new System.EventHandler(this.adaugadatelebuton_Click);
            // 
            // PanelMeniu
            // 
            this.PanelMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelMeniu.Controls.Add(this.LogoPanle);
            this.PanelMeniu.Controls.Add(this.adaugadatelebuton);
            this.PanelMeniu.Controls.Add(this.CatalogButtonMeniu);
            this.PanelMeniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMeniu.Location = new System.Drawing.Point(0, 0);
            this.PanelMeniu.Name = "PanelMeniu";
            this.PanelMeniu.Size = new System.Drawing.Size(270, 571);
            this.PanelMeniu.TabIndex = 5;
            // 
            // LogoPanle
            // 
            this.LogoPanle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.LogoPanle.Controls.Add(this.logoLabel);
            this.LogoPanle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanle.Location = new System.Drawing.Point(0, 0);
            this.LogoPanle.Name = "LogoPanle";
            this.LogoPanle.Size = new System.Drawing.Size(270, 80);
            this.LogoPanle.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(9, 24);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(255, 28);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Proiect Licenta Mananger";
            this.logoLabel.Click += new System.EventHandler(this.logoLabel_Click);
            // 
            // panelTitleBlock
            // 
            this.panelTitleBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBlock.Controls.Add(this.btnMinimize);
            this.panelTitleBlock.Controls.Add(this.btnMaximize);
            this.panelTitleBlock.Controls.Add(this.closeButton);
            this.panelTitleBlock.Controls.Add(this.TitleBlockLabel);
            this.panelTitleBlock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBlock.Location = new System.Drawing.Point(270, 0);
            this.panelTitleBlock.Name = "panelTitleBlock";
            this.panelTitleBlock.Size = new System.Drawing.Size(801, 80);
            this.panelTitleBlock.TabIndex = 6;
            this.panelTitleBlock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBlock_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("SansSerif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(684, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 37);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("SansSerif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(724, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(34, 37);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::CatalogStudenti.Properties.Resources.Untitled_design__2_;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("SansSerif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(764, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 37);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "O";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TitleBlockLabel
            // 
            this.TitleBlockLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBlockLabel.AutoSize = true;
            this.TitleBlockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBlockLabel.ForeColor = System.Drawing.Color.White;
            this.TitleBlockLabel.Location = new System.Drawing.Point(307, 24);
            this.TitleBlockLabel.Name = "TitleBlockLabel";
            this.TitleBlockLabel.Size = new System.Drawing.Size(99, 31);
            this.TitleBlockLabel.TabIndex = 0;
            this.TitleBlockLabel.Text = "HOME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CatalogStudenti.Properties.Resources.Untitled_design__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(362, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTitleBlock);
            this.Controls.Add(this.PanelMeniu);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.PanelMeniu.ResumeLayout(false);
            this.LogoPanle.ResumeLayout(false);
            this.LogoPanle.PerformLayout();
            this.panelTitleBlock.ResumeLayout(false);
            this.panelTitleBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button CatalogButtonMeniu;
        private System.Windows.Forms.Button adaugadatelebuton;
        private System.Windows.Forms.Panel PanelMeniu;
        private System.Windows.Forms.Panel LogoPanle;
        private System.Windows.Forms.Panel panelTitleBlock;
        private System.Windows.Forms.Label TitleBlockLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}