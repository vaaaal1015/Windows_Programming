
namespace CourseSelection
{
    partial class StartUpForm
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
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._courseSelectingSystemButton = new System.Windows.Forms.Button();
            this._courseManagementSystemButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._courseSelectingSystemButton, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._courseManagementSystemButton, 0, 1);
            this._tableLayoutPanel1.Controls.Add(this._exitButton, 0, 2);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 3;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _courseSelectingSystemButton
            // 
            this._courseSelectingSystemButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._courseSelectingSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectingSystemButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._courseSelectingSystemButton.Location = new System.Drawing.Point(3, 3);
            this._courseSelectingSystemButton.Name = "_courseSelectingSystemButton";
            this._courseSelectingSystemButton.Size = new System.Drawing.Size(794, 174);
            this._courseSelectingSystemButton.TabIndex = 0;
            this._courseSelectingSystemButton.Text = "Course Selecting System";
            this._courseSelectingSystemButton.UseVisualStyleBackColor = false;
            this._courseSelectingSystemButton.Click += new System.EventHandler(this.ClickCourseSelectingSystemButton);
            // 
            // _courseManagementSystemButton
            // 
            this._courseManagementSystemButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._courseManagementSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseManagementSystemButton.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this._courseManagementSystemButton.Location = new System.Drawing.Point(3, 183);
            this._courseManagementSystemButton.Name = "_courseManagementSystemButton";
            this._courseManagementSystemButton.Size = new System.Drawing.Size(794, 174);
            this._courseManagementSystemButton.TabIndex = 1;
            this._courseManagementSystemButton.Text = "Course Management System ";
            this._courseManagementSystemButton.UseVisualStyleBackColor = false;
            this._courseManagementSystemButton.Click += new System.EventHandler(this.ClickCourseManagementSystemButton);
            // 
            // _exitButton
            // 
            this._exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._exitButton.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this._exitButton.Location = new System.Drawing.Point(622, 363);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(175, 84);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = false;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this._tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Button _courseSelectingSystemButton;
        private System.Windows.Forms.Button _courseManagementSystemButton;
        private System.Windows.Forms.Button _exitButton;
    }
}