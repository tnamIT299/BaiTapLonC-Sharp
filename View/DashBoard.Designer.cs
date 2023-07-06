namespace BTL_demo.View
{
    partial class DashBoard
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
            this.pane_DashBoard = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // pane_DashBoard
            // 
            this.pane_DashBoard.BackColor = System.Drawing.Color.Transparent;
            this.pane_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pane_DashBoard.Location = new System.Drawing.Point(235, 80);
            this.pane_DashBoard.Name = "pane_DashBoard";
            this.pane_DashBoard.Size = new System.Drawing.Size(106, 27);
            this.pane_DashBoard.TabIndex = 0;
            this.pane_DashBoard.Text = "Dash Board";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 709);
            this.Controls.Add(this.pane_DashBoard);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel pane_DashBoard;
    }
}