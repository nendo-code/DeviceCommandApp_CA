﻿
namespace DeviceCommandApp.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MotorValue = new System.Windows.Forms.Label();
            this.SensorValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "モーターの状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "センサーの状態";
            // 
            // MotorValue
            // 
            this.MotorValue.AutoSize = true;
            this.MotorValue.Location = new System.Drawing.Point(103, 21);
            this.MotorValue.Name = "MotorValue";
            this.MotorValue.Size = new System.Drawing.Size(35, 15);
            this.MotorValue.TabIndex = 2;
            this.MotorValue.Text = "Value";
            // 
            // SensorValue
            // 
            this.SensorValue.AutoSize = true;
            this.SensorValue.Location = new System.Drawing.Point(106, 51);
            this.SensorValue.Name = "SensorValue";
            this.SensorValue.Size = new System.Drawing.Size(35, 15);
            this.SensorValue.TabIndex = 3;
            this.SensorValue.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 367);
            this.Controls.Add(this.SensorValue);
            this.Controls.Add(this.MotorValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MotorValue;
        private System.Windows.Forms.Label SensorValue;
    }
}

