
namespace MultiPurposeProjectOptimizer
{
    partial class SolverInputsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolveButton = new System.Windows.Forms.Button();
            this.SolverInputsGrid = new System.Windows.Forms.DataGridView();
            this.SolverInputsSetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionQuantityCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptimalProjectsButton = new System.Windows.Forms.Button();
            this.InitialProjectsButton = new System.Windows.Forms.Button();
            this.CapsButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.MaximizedPropertyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SolverInputsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(463, 205);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(97, 23);
            this.SolveButton.TabIndex = 0;
            this.SolveButton.Text = "Решить";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // SolverInputsGrid
            // 
            this.SolverInputsGrid.AllowUserToDeleteRows = false;
            this.SolverInputsGrid.CausesValidation = false;
            this.SolverInputsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolverInputsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolverInputsSetId,
            this.RowNumber,
            this.SetName,
            this.solutionQuantityCap});
            this.SolverInputsGrid.Location = new System.Drawing.Point(6, 19);
            this.SolverInputsGrid.Name = "SolverInputsGrid";
            this.SolverInputsGrid.Size = new System.Drawing.Size(451, 209);
            this.SolverInputsGrid.TabIndex = 1;
            this.SolverInputsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SolverInputsGrid_CellValueChanged);
            this.SolverInputsGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.SolverInputsGrid_RowValidated);
            this.SolverInputsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SolverInputsGrid_RowValidating);
            // 
            // SolverInputsSetId
            // 
            this.SolverInputsSetId.HeaderText = "SolverSetId";
            this.SolverInputsSetId.Name = "SolverInputsSetId";
            this.SolverInputsSetId.ReadOnly = true;
            this.SolverInputsSetId.Visible = false;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "№";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            // 
            // SetName
            // 
            this.SetName.HeaderText = "Название задачи";
            this.SetName.Name = "SetName";
            // 
            // solutionQuantityCap
            // 
            this.solutionQuantityCap.HeaderText = "Ограничение на количество решений";
            this.solutionQuantityCap.Name = "solutionQuantityCap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaximizedPropertyButton);
            this.groupBox1.Controls.Add(this.OptimalProjectsButton);
            this.groupBox1.Controls.Add(this.InitialProjectsButton);
            this.groupBox1.Controls.Add(this.CapsButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.SolverInputsGrid);
            this.groupBox1.Controls.Add(this.SolveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наборы вводных данных и решений";
            // 
            // OptimalProjectsButton
            // 
            this.OptimalProjectsButton.Location = new System.Drawing.Point(463, 132);
            this.OptimalProjectsButton.Name = "OptimalProjectsButton";
            this.OptimalProjectsButton.Size = new System.Drawing.Size(97, 38);
            this.OptimalProjectsButton.TabIndex = 8;
            this.OptimalProjectsButton.Text = "Оптимальный набор проектов";
            this.OptimalProjectsButton.UseVisualStyleBackColor = true;
            this.OptimalProjectsButton.Click += new System.EventHandler(this.OptimalProjectsButton_Click);
            // 
            // InitialProjectsButton
            // 
            this.InitialProjectsButton.Location = new System.Drawing.Point(463, 91);
            this.InitialProjectsButton.Name = "InitialProjectsButton";
            this.InitialProjectsButton.Size = new System.Drawing.Size(97, 35);
            this.InitialProjectsButton.TabIndex = 7;
            this.InitialProjectsButton.Text = "Вводный набор проектов";
            this.InitialProjectsButton.UseVisualStyleBackColor = true;
            this.InitialProjectsButton.Click += new System.EventHandler(this.InitialProjectsButton_Click);
            // 
            // CapsButton
            // 
            this.CapsButton.Location = new System.Drawing.Point(463, 19);
            this.CapsButton.Name = "CapsButton";
            this.CapsButton.Size = new System.Drawing.Size(97, 23);
            this.CapsButton.TabIndex = 6;
            this.CapsButton.Text = "Ограничения";
            this.CapsButton.UseVisualStyleBackColor = true;
            this.CapsButton.Click += new System.EventHandler(this.CapsButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(463, 176);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(475, 268);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MaximizedPropertyButton
            // 
            this.MaximizedPropertyButton.Location = new System.Drawing.Point(463, 48);
            this.MaximizedPropertyButton.Name = "MaximizedPropertyButton";
            this.MaximizedPropertyButton.Size = new System.Drawing.Size(97, 37);
            this.MaximizedPropertyButton.TabIndex = 9;
            this.MaximizedPropertyButton.Text = "Максимизируемое свойство";
            this.MaximizedPropertyButton.UseVisualStyleBackColor = true;
            this.MaximizedPropertyButton.Click += new System.EventHandler(this.MaximizedPropertyButton_Click);
            // 
            // SolverInputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 303);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SolverInputsForm";
            this.Text = "Решение задач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolverInputsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SolverInputsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.DataGridView SolverInputsGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button OptimalProjectsButton;
        private System.Windows.Forms.Button InitialProjectsButton;
        private System.Windows.Forms.Button CapsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolverInputsSetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionQuantityCap;
        private System.Windows.Forms.Button MaximizedPropertyButton;
    }
}

