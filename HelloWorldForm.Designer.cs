namespace COMP123_S2019_Lesson7C
{
    partial class HelloWorldForm
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
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.RandomNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HelloWorldLabel.Location = new System.Drawing.Point(246, 142);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(238, 36);
            this.HelloWorldLabel.TabIndex = 0;
            this.HelloWorldLabel.Text = "Hello, world!";
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClickMeButton.Location = new System.Drawing.Point(47, 175);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(183, 36);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // RandomNumberLabel
            // 
            this.RandomNumberLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomNumberLabel.Location = new System.Drawing.Point(246, 199);
            this.RandomNumberLabel.Name = "RandomNumberLabel";
            this.RandomNumberLabel.Size = new System.Drawing.Size(238, 36);
            this.RandomNumberLabel.TabIndex = 2;
            this.RandomNumberLabel.Text = "99";
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.RandomNumberLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.HelloWorldLabel);
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label RandomNumberLabel;
    }
}

