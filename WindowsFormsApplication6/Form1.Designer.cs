﻿namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(77, 72);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(158, 72);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(239, 72);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(158, 153);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(239, 153);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(77, 153);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(239, 234);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 6;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(158, 234);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(77, 234);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 371);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;

    }
}

