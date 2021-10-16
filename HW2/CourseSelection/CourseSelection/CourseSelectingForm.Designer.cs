
namespace CourseSelection
{
    partial class CourseSelectingForm
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
            this._flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._dataGridView1 = new System.Windows.Forms.DataGridView();
            this._flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _flowLayoutPanel1
            // 
            this._flowLayoutPanel1.Controls.Add(this._dataGridView1);
            this._flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._flowLayoutPanel1.Name = "_flowLayoutPanel1";
            this._flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this._flowLayoutPanel1.TabIndex = 0;
            // 
            // _dataGridView1
            // 
            this._dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView1.Location = new System.Drawing.Point(3, 3);
            this._dataGridView1.Name = "_dataGridView1";
            this._dataGridView1.RowTemplate.Height = 24;
            this._dataGridView1.Size = new System.Drawing.Size(240, 0);
            this._dataGridView1.TabIndex = 0;
            // 
            // CourseSelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._flowLayoutPanel1);
            this.Name = "CourseSelectingForm";
            this.Text = "CourseSelectingForm";
            this._flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel1;
        private System.Windows.Forms.DataGridView _dataGridView1;
    }
}