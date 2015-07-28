namespace SimpleBackup
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonStartBackup = new System.Windows.Forms.Button();
            this.browseSource = new System.Windows.Forms.Button();
            this.browseTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(27, 17);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(62, 18);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(109, 14);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(327, 24);
            this.textBoxSource.TabIndex = 1;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(27, 70);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(56, 18);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Target";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(109, 64);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(327, 24);
            this.textBoxTarget.TabIndex = 3;
            // 
            // buttonStartBackup
            // 
            this.buttonStartBackup.Location = new System.Drawing.Point(209, 149);
            this.buttonStartBackup.Name = "buttonStartBackup";
            this.buttonStartBackup.Size = new System.Drawing.Size(137, 27);
            this.buttonStartBackup.TabIndex = 4;
            this.buttonStartBackup.Text = "Start Backup";
            this.buttonStartBackup.UseVisualStyleBackColor = true;
            this.buttonStartBackup.Click += new System.EventHandler(this.buttonStartBackup_Click);
            // 
            // browseSource
            // 
            this.browseSource.Location = new System.Drawing.Point(459, 12);
            this.browseSource.Name = "browseSource";
            this.browseSource.Size = new System.Drawing.Size(82, 26);
            this.browseSource.TabIndex = 5;
            this.browseSource.Text = "browse";
            this.browseSource.UseVisualStyleBackColor = true;
            this.browseSource.Click += new System.EventHandler(this.browseSource_Click);
            // 
            // browseTarget
            // 
            this.browseTarget.Location = new System.Drawing.Point(459, 63);
            this.browseTarget.Name = "browseTarget";
            this.browseTarget.Size = new System.Drawing.Size(82, 26);
            this.browseTarget.TabIndex = 6;
            this.browseTarget.Text = "browse";
            this.browseTarget.UseVisualStyleBackColor = true;
            this.browseTarget.Click += new System.EventHandler(this.browseTarget_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 198);
            this.Controls.Add(this.browseTarget);
            this.Controls.Add(this.browseSource);
            this.Controls.Add(this.buttonStartBackup);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.labelSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Backup v0.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button buttonStartBackup;
        private System.Windows.Forms.Button browseSource;
        private System.Windows.Forms.Button browseTarget;
    }
}

