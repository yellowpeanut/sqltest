
namespace sqltest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.connBtn = new System.Windows.Forms.Button();
            this.connStatBtn = new System.Windows.Forms.Button();
            this.discBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 430);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 197);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(616, 587);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(90, 40);
            this.queryBtn.TabIndex = 2;
            this.queryBtn.Text = "Выполнить запрос";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(616, 430);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(90, 40);
            this.connBtn.TabIndex = 3;
            this.connBtn.Text = "Подключиться к БД";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // connStatBtn
            // 
            this.connStatBtn.Location = new System.Drawing.Point(712, 430);
            this.connStatBtn.Name = "connStatBtn";
            this.connStatBtn.Size = new System.Drawing.Size(90, 40);
            this.connStatBtn.TabIndex = 4;
            this.connStatBtn.Text = "Статус подключения";
            this.connStatBtn.UseVisualStyleBackColor = true;
            this.connStatBtn.Click += new System.EventHandler(this.connStatBtn_Click);
            // 
            // discBtn
            // 
            this.discBtn.Location = new System.Drawing.Point(808, 430);
            this.discBtn.Name = "discBtn";
            this.discBtn.Size = new System.Drawing.Size(90, 40);
            this.discBtn.TabIndex = 5;
            this.discBtn.Text = "Отключиться от БД";
            this.discBtn.UseVisualStyleBackColor = true;
            this.discBtn.Click += new System.EventHandler(this.discBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(616, 491);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(90, 40);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Вывести таблицу";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sqltest.Properties.Resources.X_pFs8HsI_Y;
            this.pictureBox1.Location = new System.Drawing.Point(617, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "client",
            "employees",
            "log",
            "product",
            "storage"});
            this.comboBox1.Location = new System.Drawing.Point(617, 537);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 639);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.discBtn);
            this.Controls.Add(this.connStatBtn);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button connBtn;
        private System.Windows.Forms.Button connStatBtn;
        private System.Windows.Forms.Button discBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

