
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
            this.button1 = new System.Windows.Forms.Button();
            this.SolverInputsGrid = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapsListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapButtonsRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptimalProjectList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SolverInputsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolverInputsGrid
            // 
            this.SolverInputsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolverInputsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.CapsListName,
            this.CapButtonsRow,
            this.Column1,
            this.OptimalProjectList});
            this.SolverInputsGrid.Location = new System.Drawing.Point(6, 19);
            this.SolverInputsGrid.Name = "SolverInputsGrid";
            this.SolverInputsGrid.Size = new System.Drawing.Size(540, 150);
            this.SolverInputsGrid.TabIndex = 1;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "№";
            this.RowNumber.Name = "RowNumber";
            // 
            // CapsListName
            // 
            this.CapsListName.HeaderText = "Название набора ограничений";
            this.CapsListName.Name = "CapsListName";
            // 
            // CapButtonsRow
            // 
            this.CapButtonsRow.HeaderText = "Ограничения";
            this.CapButtonsRow.Name = "CapButtonsRow";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Вводный набор проектов";
            this.Column1.Name = "Column1";
            // 
            // OptimalProjectList
            // 
            this.OptimalProjectList.HeaderText = "Оптимальный набор проектов";
            this.OptimalProjectList.Name = "OptimalProjectList";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.SolverInputsGrid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наборы вводных данных и решений";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(552, 146);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SolverInputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 219);
            this.Controls.Add(this.groupBox1);
            this.Name = "SolverInputsForm";
            this.Text = "Решение задач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolverInputsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SolverInputsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView SolverInputsGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapsListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapButtonsRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptimalProjectList;
    }
}

