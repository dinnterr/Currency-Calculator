﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NBU = new System.Windows.Forms.GroupBox();
            this.perevodnbu = new System.Windows.Forms.Label();
            this.nbuusd = new System.Windows.Forms.TextBox();
            this.uahn2 = new System.Windows.Forms.Label();
            this.usdn = new System.Windows.Forms.Label();
            this.uahn = new System.Windows.Forms.Label();
            this.euron = new System.Windows.Forms.Label();
            this.nbueur = new System.Windows.Forms.TextBox();
            this.privatBank = new System.Windows.Forms.GroupBox();
            this.sale = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Label();
            this.btcsale = new System.Windows.Forms.TextBox();
            this.usdsale = new System.Windows.Forms.TextBox();
            this.eurosale = new System.Windows.Forms.TextBox();
            this.btcbuy = new System.Windows.Forms.TextBox();
            this.usdbuy = new System.Windows.Forms.TextBox();
            this.usdp = new System.Windows.Forms.Label();
            this.uahp2 = new System.Windows.Forms.Label();
            this.btc = new System.Windows.Forms.Label();
            this.usd = new System.Windows.Forms.Label();
            this.uahp1 = new System.Windows.Forms.Label();
            this.eur = new System.Windows.Forms.Label();
            this.eurobuy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sum3 = new System.Windows.Forms.TextBox();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.choose1 = new System.Windows.Forms.ComboBox();
            this.choose2 = new System.Windows.Forms.ComboBox();
            this.inversion = new System.Windows.Forms.PictureBox();
            this.bank = new System.Windows.Forms.ComboBox();
            this.choose = new System.Windows.Forms.Label();
            this.currencyHead = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.NBU.SuspendLayout();
            this.privatBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inversion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NBU);
            this.panel1.Controls.Add(this.privatBank);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sum2);
            this.panel1.Controls.Add(this.sum3);
            this.panel1.Controls.Add(this.sum1);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.choose1);
            this.panel1.Controls.Add(this.choose2);
            this.panel1.Controls.Add(this.inversion);
            this.panel1.Controls.Add(this.bank);
            this.panel1.Controls.Add(this.choose);
            this.panel1.Controls.Add(this.currencyHead);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 535);
            this.panel1.TabIndex = 0;
            // 
            // NBU
            // 
            this.NBU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NBU.Controls.Add(this.perevodnbu);
            this.NBU.Controls.Add(this.nbuusd);
            this.NBU.Controls.Add(this.uahn2);
            this.NBU.Controls.Add(this.usdn);
            this.NBU.Controls.Add(this.uahn);
            this.NBU.Controls.Add(this.euron);
            this.NBU.Controls.Add(this.nbueur);
            this.NBU.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NBU.Location = new System.Drawing.Point(0, 72);
            this.NBU.Name = "NBU";
            this.NBU.Size = new System.Drawing.Size(552, 137);
            this.NBU.TabIndex = 44;
            this.NBU.TabStop = false;
            // 
            // perevodnbu
            // 
            this.perevodnbu.AutoSize = true;
            this.perevodnbu.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perevodnbu.Location = new System.Drawing.Point(385, 18);
            this.perevodnbu.Name = "perevodnbu";
            this.perevodnbu.Size = new System.Drawing.Size(92, 25);
            this.perevodnbu.TabIndex = 50;
            this.perevodnbu.Text = "для UAH";
            // 
            // nbuusd
            // 
            this.nbuusd.Location = new System.Drawing.Point(343, 89);
            this.nbuusd.Name = "nbuusd";
            this.nbuusd.ReadOnly = true;
            this.nbuusd.Size = new System.Drawing.Size(163, 35);
            this.nbuusd.TabIndex = 45;
            this.nbuusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uahn2
            // 
            this.uahn2.AutoSize = true;
            this.uahn2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uahn2.Location = new System.Drawing.Point(135, 96);
            this.uahn2.Name = "uahn2";
            this.uahn2.Size = new System.Drawing.Size(59, 28);
            this.uahn2.TabIndex = 43;
            this.uahn2.Text = "UAH";
            // 
            // usdn
            // 
            this.usdn.AutoSize = true;
            this.usdn.Location = new System.Drawing.Point(58, 96);
            this.usdn.Name = "usdn";
            this.usdn.Size = new System.Drawing.Size(56, 28);
            this.usdn.TabIndex = 39;
            this.usdn.Text = "USD";
            // 
            // uahn
            // 
            this.uahn.AutoSize = true;
            this.uahn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uahn.Location = new System.Drawing.Point(135, 51);
            this.uahn.Name = "uahn";
            this.uahn.Size = new System.Drawing.Size(59, 28);
            this.uahn.TabIndex = 38;
            this.uahn.Text = "UAH";
            // 
            // euron
            // 
            this.euron.AutoSize = true;
            this.euron.Location = new System.Drawing.Point(58, 51);
            this.euron.Name = "euron";
            this.euron.Size = new System.Drawing.Size(54, 28);
            this.euron.TabIndex = 37;
            this.euron.Text = "EUR";
            // 
            // nbueur
            // 
            this.nbueur.Location = new System.Drawing.Point(343, 48);
            this.nbueur.Name = "nbueur";
            this.nbueur.ReadOnly = true;
            this.nbueur.Size = new System.Drawing.Size(163, 35);
            this.nbueur.TabIndex = 31;
            this.nbueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // privatBank
            // 
            this.privatBank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.privatBank.Controls.Add(this.sale);
            this.privatBank.Controls.Add(this.buy);
            this.privatBank.Controls.Add(this.btcsale);
            this.privatBank.Controls.Add(this.usdsale);
            this.privatBank.Controls.Add(this.eurosale);
            this.privatBank.Controls.Add(this.btcbuy);
            this.privatBank.Controls.Add(this.usdbuy);
            this.privatBank.Controls.Add(this.usdp);
            this.privatBank.Controls.Add(this.uahp2);
            this.privatBank.Controls.Add(this.btc);
            this.privatBank.Controls.Add(this.usd);
            this.privatBank.Controls.Add(this.uahp1);
            this.privatBank.Controls.Add(this.eur);
            this.privatBank.Controls.Add(this.eurobuy);
            this.privatBank.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privatBank.Location = new System.Drawing.Point(3, 68);
            this.privatBank.Name = "privatBank";
            this.privatBank.Size = new System.Drawing.Size(552, 171);
            this.privatBank.TabIndex = 43;
            this.privatBank.TabStop = false;
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sale.Location = new System.Drawing.Point(417, 20);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(89, 25);
            this.sale.TabIndex = 51;
            this.sale.Text = "Продаж";
            // 
            // buy
            // 
            this.buy.AutoSize = true;
            this.buy.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy.Location = new System.Drawing.Point(229, 20);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(83, 25);
            this.buy.TabIndex = 50;
            this.buy.Text = "Купівля";
            // 
            // btcsale
            // 
            this.btcsale.Location = new System.Drawing.Point(380, 130);
            this.btcsale.Name = "btcsale";
            this.btcsale.ReadOnly = true;
            this.btcsale.Size = new System.Drawing.Size(163, 35);
            this.btcsale.TabIndex = 49;
            this.btcsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usdsale
            // 
            this.usdsale.Location = new System.Drawing.Point(380, 89);
            this.usdsale.Name = "usdsale";
            this.usdsale.ReadOnly = true;
            this.usdsale.Size = new System.Drawing.Size(163, 35);
            this.usdsale.TabIndex = 48;
            this.usdsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eurosale
            // 
            this.eurosale.Location = new System.Drawing.Point(380, 48);
            this.eurosale.Name = "eurosale";
            this.eurosale.ReadOnly = true;
            this.eurosale.Size = new System.Drawing.Size(163, 35);
            this.eurosale.TabIndex = 47;
            this.eurosale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btcbuy
            // 
            this.btcbuy.Location = new System.Drawing.Point(192, 130);
            this.btcbuy.Name = "btcbuy";
            this.btcbuy.ReadOnly = true;
            this.btcbuy.Size = new System.Drawing.Size(163, 35);
            this.btcbuy.TabIndex = 46;
            this.btcbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usdbuy
            // 
            this.usdbuy.Location = new System.Drawing.Point(192, 89);
            this.usdbuy.Name = "usdbuy";
            this.usdbuy.ReadOnly = true;
            this.usdbuy.Size = new System.Drawing.Size(163, 35);
            this.usdbuy.TabIndex = 45;
            this.usdbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usdp
            // 
            this.usdp.AutoSize = true;
            this.usdp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usdp.Location = new System.Drawing.Point(99, 133);
            this.usdp.Name = "usdp";
            this.usdp.Size = new System.Drawing.Size(56, 28);
            this.usdp.TabIndex = 44;
            this.usdp.Text = "USD";
            // 
            // uahp2
            // 
            this.uahp2.AutoSize = true;
            this.uahp2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uahp2.Location = new System.Drawing.Point(99, 92);
            this.uahp2.Name = "uahp2";
            this.uahp2.Size = new System.Drawing.Size(59, 28);
            this.uahp2.TabIndex = 43;
            this.uahp2.Text = "UAH";
            // 
            // btc
            // 
            this.btc.AutoSize = true;
            this.btc.Location = new System.Drawing.Point(17, 133);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(51, 28);
            this.btc.TabIndex = 41;
            this.btc.Text = "BTC";
            // 
            // usd
            // 
            this.usd.AutoSize = true;
            this.usd.Location = new System.Drawing.Point(17, 92);
            this.usd.Name = "usd";
            this.usd.Size = new System.Drawing.Size(56, 28);
            this.usd.TabIndex = 39;
            this.usd.Text = "USD";
            // 
            // uahp1
            // 
            this.uahp1.AutoSize = true;
            this.uahp1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uahp1.Location = new System.Drawing.Point(99, 51);
            this.uahp1.Name = "uahp1";
            this.uahp1.Size = new System.Drawing.Size(59, 28);
            this.uahp1.TabIndex = 38;
            this.uahp1.Text = "UAH";
            // 
            // eur
            // 
            this.eur.AutoSize = true;
            this.eur.Location = new System.Drawing.Point(17, 51);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(54, 28);
            this.eur.TabIndex = 37;
            this.eur.Text = "EUR";
            // 
            // eurobuy
            // 
            this.eurobuy.Location = new System.Drawing.Point(192, 48);
            this.eurobuy.Name = "eurobuy";
            this.eurobuy.ReadOnly = true;
            this.eurobuy.Size = new System.Drawing.Size(163, 35);
            this.eurobuy.TabIndex = 31;
            this.eurobuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "за курсом ПриватБанку:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "за курсом НБУ:";
            // 
            // sum2
            // 
            this.sum2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum2.BackColor = System.Drawing.Color.White;
            this.sum2.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sum2.Location = new System.Drawing.Point(296, 377);
            this.sum2.MaximumSize = new System.Drawing.Size(250, 90);
            this.sum2.Multiline = true;
            this.sum2.Name = "sum2";
            this.sum2.ReadOnly = true;
            this.sum2.Size = new System.Drawing.Size(247, 58);
            this.sum2.TabIndex = 28;
            this.sum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sum3
            // 
            this.sum3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum3.BackColor = System.Drawing.Color.White;
            this.sum3.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sum3.Location = new System.Drawing.Point(296, 465);
            this.sum3.MaximumSize = new System.Drawing.Size(250, 90);
            this.sum3.Multiline = true;
            this.sum3.Name = "sum3";
            this.sum3.ReadOnly = true;
            this.sum3.Size = new System.Drawing.Size(247, 58);
            this.sum3.TabIndex = 24;
            this.sum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sum1
            // 
            this.sum1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum1.Location = new System.Drawing.Point(12, 395);
            this.sum1.MaximumSize = new System.Drawing.Size(250, 90);
            this.sum1.Multiline = true;
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(250, 67);
            this.sum1.TabIndex = 23;
            this.sum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum1.Enter += new System.EventHandler(this.sum1_Enter);
            this.sum1.Leave += new System.EventHandler(this.sum1_Leave);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count.BackColor = System.Drawing.Color.White;
            this.count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.count.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.count.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(209)))), ((int)(((byte)(109)))));
            this.count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(252)))), ((int)(((byte)(174)))));
            this.count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(47, 477);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(180, 46);
            this.count.TabIndex = 26;
            this.count.Text = "Порахувати";
            this.count.UseVisualStyleBackColor = false;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // choose1
            // 
            this.choose1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose1.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "BTC"});
            this.choose1.Location = new System.Drawing.Point(12, 348);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(92, 32);
            this.choose1.TabIndex = 18;
            // 
            // choose2
            // 
            this.choose2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose2.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "BTC"});
            this.choose2.Location = new System.Drawing.Point(170, 348);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(92, 32);
            this.choose2.TabIndex = 20;
            // 
            // inversion
            // 
            this.inversion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inversion.Image = global::Currency_Calculator.Properties.Resources.directions;
            this.inversion.Location = new System.Drawing.Point(118, 348);
            this.inversion.Name = "inversion";
            this.inversion.Size = new System.Drawing.Size(40, 40);
            this.inversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inversion.TabIndex = 25;
            this.inversion.TabStop = false;
            this.inversion.Click += new System.EventHandler(this.inversion_Click);
            // 
            // bank
            // 
            this.bank.BackColor = System.Drawing.Color.White;
            this.bank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bank.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bank.ItemHeight = 18;
            this.bank.Items.AddRange(new object[] {
            "НБУ",
            "ПриватБанк"});
            this.bank.Location = new System.Drawing.Point(234, 40);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(121, 26);
            this.bank.TabIndex = 27;
            // 
            // choose
            // 
            this.choose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choose.AutoSize = true;
            this.choose.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose.Location = new System.Drawing.Point(230, 312);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(112, 24);
            this.choose.TabIndex = 19;
            this.choose.Text = "Конвертер";
            // 
            // currencyHead
            // 
            this.currencyHead.AutoSize = true;
            this.currencyHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.currencyHead.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyHead.Location = new System.Drawing.Point(0, 37);
            this.currencyHead.Name = "currencyHead";
            this.currencyHead.Size = new System.Drawing.Size(237, 28);
            this.currencyHead.TabIndex = 1;
            this.currencyHead.Text = "Актуальний курс валют";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.mainHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 37);
            this.panel2.TabIndex = 0;
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(115)))), ((int)(((byte)(37)))));
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainHeader.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(555, 37);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Text = "Калькулятор валют";
            this.mainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(209)))), ((int)(((byte)(109)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(252)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 242);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(555, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "Отримати курс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 535);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 574);
            this.Name = "CurrencyCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.CurrencyCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NBU.ResumeLayout(false);
            this.NBU.PerformLayout();
            this.privatBank.ResumeLayout(false);
            this.privatBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inversion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currencyHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox choose2;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.ComboBox choose1;
        private System.Windows.Forms.TextBox sum3;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.PictureBox inversion;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label mainHeader;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.GroupBox privatBank;
        private System.Windows.Forms.Label btc;
        private System.Windows.Forms.Label usd;
        private System.Windows.Forms.Label uahp1;
        private System.Windows.Forms.Label eur;
        private System.Windows.Forms.TextBox eurobuy;
        private System.Windows.Forms.Label uahp2;
        private System.Windows.Forms.Label usdp;
        private System.Windows.Forms.TextBox btcbuy;
        private System.Windows.Forms.TextBox usdbuy;
        private System.Windows.Forms.TextBox btcsale;
        private System.Windows.Forms.TextBox usdsale;
        private System.Windows.Forms.TextBox eurosale;
        private System.Windows.Forms.Label sale;
        private System.Windows.Forms.Label buy;
        private System.Windows.Forms.GroupBox NBU;
        private System.Windows.Forms.Label perevodnbu;
        private System.Windows.Forms.TextBox nbuusd;
        private System.Windows.Forms.Label uahn2;
        private System.Windows.Forms.Label usdn;
        private System.Windows.Forms.Label uahn;
        private System.Windows.Forms.Label euron;
        private System.Windows.Forms.TextBox nbueur;
    }
}