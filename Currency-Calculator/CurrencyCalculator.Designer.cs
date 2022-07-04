
namespace Currency_Calculator
{
    partial class CurrencyCalculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.count = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.choose2 = new System.Windows.Forms.ComboBox();
            this.choose = new System.Windows.Forms.Label();
            this.choose1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.eurBuy = new System.Windows.Forms.DataGridView();
            this.currencyHead = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eurBuy)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sum2);
            this.panel1.Controls.Add(this.sum1);
            this.panel1.Controls.Add(this.choose2);
            this.panel1.Controls.Add(this.choose);
            this.panel1.Controls.Add(this.choose1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.eurBuy);
            this.panel1.Controls.Add(this.currencyHead);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 461);
            this.panel1.TabIndex = 0;
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(227, 383);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(155, 66);
            this.count.TabIndex = 26;
            this.count.Text = "Порахувати";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Currency_Calculator.Properties.Resources.directions;
            this.pictureBox1.Location = new System.Drawing.Point(293, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // sum2
            // 
            this.sum2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sum2.Location = new System.Drawing.Point(320, 337);
            this.sum2.Multiline = true;
            this.sum2.Name = "sum2";
            this.sum2.ReadOnly = true;
            this.sum2.Size = new System.Drawing.Size(311, 40);
            this.sum2.TabIndex = 24;
            // 
            // sum1
            // 
            this.sum1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum1.Location = new System.Drawing.Point(5, 337);
            this.sum1.Multiline = true;
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(309, 40);
            this.sum1.TabIndex = 23;
            this.sum1.Enter += new System.EventHandler(this.sum1_Enter);
            this.sum1.Leave += new System.EventHandler(this.sum1_Leave);
            // 
            // choose2
            // 
            this.choose2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose2.FormattingEnabled = true;
            this.choose2.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "BTC"});
            this.choose2.Location = new System.Drawing.Point(340, 292);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(92, 33);
            this.choose2.TabIndex = 20;
            // 
            // choose
            // 
            this.choose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose.AutoSize = true;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose.Location = new System.Drawing.Point(263, 264);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(119, 25);
            this.choose.TabIndex = 19;
            this.choose.Text = "Конвертер";
            // 
            // choose1
            // 
            this.choose1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose1.FormattingEnabled = true;
            this.choose1.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "BTC"});
            this.choose1.Location = new System.Drawing.Point(195, 292);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(92, 33);
            this.choose1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 182);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(634, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "Отримати курс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eurBuy
            // 
            this.eurBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eurBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eurBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eurBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eurBuy.DefaultCellStyle = dataGridViewCellStyle2;
            this.eurBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.eurBuy.Location = new System.Drawing.Point(0, 65);
            this.eurBuy.Name = "eurBuy";
            this.eurBuy.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eurBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.eurBuy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.eurBuy.Size = new System.Drawing.Size(634, 117);
            this.eurBuy.TabIndex = 16;
            this.eurBuy.Tag = "";
            // 
            // currencyHead
            // 
            this.currencyHead.AutoSize = true;
            this.currencyHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.currencyHead.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyHead.Location = new System.Drawing.Point(0, 37);
            this.currencyHead.Name = "currencyHead";
            this.currencyHead.Size = new System.Drawing.Size(370, 28);
            this.currencyHead.TabIndex = 1;
            this.currencyHead.Text = "Актуальний курс валют (ПриватБанк)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.mainHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 37);
            this.panel2.TabIndex = 0;
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.Olive;
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainHeader.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(634, 37);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Text = "Калькулятор валют";
            this.mainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrencyCalculator";
            this.Text = "CurrencyCalculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eurBuy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currencyHead;
        private System.Windows.Forms.DataGridView eurBuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox choose2;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.ComboBox choose1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label mainHeader;
    }
}