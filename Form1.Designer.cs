namespace AppOrder
{
    partial class Form1
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
            this.btnShowOrders = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.LabelName = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowOrders.Location = new System.Drawing.Point(350, 132);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(422, 85);
            this.btnShowOrders.TabIndex = 1;
            this.btnShowOrders.Text = "Orders";
            this.btnShowOrders.UseVisualStyleBackColor = false;
            this.btnShowOrders.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(454, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 16;
            this.listBoxCustomers.Location = new System.Drawing.Point(49, 46);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(222, 388);
            this.listBoxCustomers.TabIndex = 4;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(350, 267);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(422, 167);
            this.dataGridViewOrders.TabIndex = 5;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelName.Location = new System.Drawing.Point(354, 46);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(57, 29);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "City";
            this.LabelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(44, 79);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 29);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(291, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnShowOrders);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowOrders;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label label1;
    }
}

