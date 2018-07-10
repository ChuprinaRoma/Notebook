namespace Notebook
{
    partial class Tabla
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHT,
            this.firstNameHT,
            this.lastNameHT,
            this.numbHT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // idHT
            // 
            this.idHT.HeaderText = "id";
            this.idHT.Name = "idHT";
            // 
            // firstNameHT
            // 
            this.firstNameHT.HeaderText = "Имя";
            this.firstNameHT.Name = "firstNameHT";
            // 
            // lastNameHT
            // 
            this.lastNameHT.HeaderText = "Фамилия";
            this.lastNameHT.Name = "lastNameHT";
            // 
            // numbHT
            // 
            this.numbHT.HeaderText = "number";
            this.numbHT.Name = "numbHT";
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tabla";
            this.Size = new System.Drawing.Size(447, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbHT;
    }
}
