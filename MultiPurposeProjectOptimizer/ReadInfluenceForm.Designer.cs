
namespace MultiPurposeProjectOptimizer
{
    partial class ReadInfluenceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.InfluencesGrid = new System.Windows.Forms.DataGridView();
            this.InfluenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedProjectPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluenceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfluencesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Влияния проекта в данной задаче";
            // 
            // InfluencesGrid
            // 
            this.InfluencesGrid.AllowUserToAddRows = false;
            this.InfluencesGrid.AllowUserToDeleteRows = false;
            this.InfluencesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfluencesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfluenceId,
            this.dataGridViewTextBoxColumn3,
            this.InfluencedProjectId,
            this.dataGridViewTextBoxColumn5,
            this.InfluencedProjectPropertyId,
            this.InfluencedPropertyId,
            this.InfluencedPropertyName,
            this.InfluenceValue});
            this.InfluencesGrid.Location = new System.Drawing.Point(12, 56);
            this.InfluencesGrid.Name = "InfluencesGrid";
            this.InfluencesGrid.ReadOnly = true;
            this.InfluencesGrid.Size = new System.Drawing.Size(443, 253);
            this.InfluencesGrid.TabIndex = 28;
            // 
            // InfluenceId
            // 
            this.InfluenceId.HeaderText = "InfluenceId";
            this.InfluenceId.Name = "InfluenceId";
            this.InfluenceId.ReadOnly = true;
            this.InfluenceId.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "№";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // InfluencedProjectId
            // 
            this.InfluencedProjectId.HeaderText = "InflluenceProjectId";
            this.InfluencedProjectId.Name = "InfluencedProjectId";
            this.InfluencedProjectId.ReadOnly = true;
            this.InfluencedProjectId.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Название влияемого проекта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // InfluencedProjectPropertyId
            // 
            this.InfluencedProjectPropertyId.HeaderText = "InfluencedProjectPropertyId";
            this.InfluencedProjectPropertyId.Name = "InfluencedProjectPropertyId";
            this.InfluencedProjectPropertyId.ReadOnly = true;
            this.InfluencedProjectPropertyId.Visible = false;
            // 
            // InfluencedPropertyId
            // 
            this.InfluencedPropertyId.HeaderText = "InfluencedPropertyId";
            this.InfluencedPropertyId.Name = "InfluencedPropertyId";
            this.InfluencedPropertyId.ReadOnly = true;
            this.InfluencedPropertyId.Visible = false;
            // 
            // InfluencedPropertyName
            // 
            this.InfluencedPropertyName.HeaderText = "Название влияемого свойства";
            this.InfluencedPropertyName.Name = "InfluencedPropertyName";
            this.InfluencedPropertyName.ReadOnly = true;
            // 
            // InfluenceValue
            // 
            this.InfluenceValue.HeaderText = "Значение влияния";
            this.InfluenceValue.Name = "InfluenceValue";
            this.InfluenceValue.ReadOnly = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(119, 331);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 30;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ReadInfluenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 393);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfluencesGrid);
            this.Name = "ReadInfluenceForm";
            this.Text = "ReadInfluenceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadInfluenceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.InfluencesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView InfluencesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedProjectPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluenceValue;
        private System.Windows.Forms.Button OKButton;
    }
}