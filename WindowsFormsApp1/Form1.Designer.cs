﻿namespace VistasRally
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
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarPilotoButton = new System.Windows.Forms.Button();
            this.PilotNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a Rally Manager";
            // 
            // AgregarPilotoButton
            // 
            this.AgregarPilotoButton.Location = new System.Drawing.Point(164, 290);
            this.AgregarPilotoButton.Name = "AgregarPilotoButton";
            this.AgregarPilotoButton.Size = new System.Drawing.Size(124, 23);
            this.AgregarPilotoButton.TabIndex = 1;
            this.AgregarPilotoButton.Text = "Agregar Piloto";
            this.AgregarPilotoButton.UseVisualStyleBackColor = true;
            this.AgregarPilotoButton.Click += new System.EventHandler(this.AgregarPilotoButton_Click);
            // 
            // PilotNameComboBox
            // 
            this.PilotNameComboBox.FormattingEnabled = true;
            this.PilotNameComboBox.Location = new System.Drawing.Point(161, 159);
            this.PilotNameComboBox.Name = "PilotNameComboBox";
            this.PilotNameComboBox.Size = new System.Drawing.Size(449, 21);
            this.PilotNameComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(198, 241);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(363, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Navegante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarNaveganteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PilotNameComboBox);
            this.Controls.Add(this.AgregarPilotoButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarPilotoButton;
        private System.Windows.Forms.ComboBox PilotNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button button1;
    }
}

