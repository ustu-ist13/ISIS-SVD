namespace VendorMachine
{
    partial class MainMenu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.splitContainerInput = new System.Windows.Forms.SplitContainer();
            this.txtDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.panelBankModule = new System.Windows.Forms.Panel();
            this.panelCurrencyReceiver = new System.Windows.Forms.Panel();
            this.btnEnterCurrency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbValuteType = new System.Windows.Forms.ComboBox();
            this.txtPar = new System.Windows.Forms.TextBox();
            this.panelKeyboard = new System.Windows.Forms.Panel();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnEnterCard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCardNumber = new System.Windows.Forms.ComboBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.cbNFC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInput)).BeginInit();
            this.splitContainerInput.Panel1.SuspendLayout();
            this.splitContainerInput.Panel2.SuspendLayout();
            this.splitContainerInput.SuspendLayout();
            this.panelBankModule.SuspendLayout();
            this.panelCurrencyReceiver.SuspendLayout();
            this.panelKeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvProducts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerInput);
            this.splitContainer1.Size = new System.Drawing.Size(941, 617);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 41);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(346, 491);
            this.dgvProducts.TabIndex = 0;
            // 
            // splitContainerInput
            // 
            this.splitContainerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInput.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInput.Name = "splitContainerInput";
            this.splitContainerInput.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInput.Panel1
            // 
            this.splitContainerInput.Panel1.Controls.Add(this.txtDisplayInfo);
            // 
            // splitContainerInput.Panel2
            // 
            this.splitContainerInput.Panel2.Controls.Add(this.panelBankModule);
            this.splitContainerInput.Panel2.Controls.Add(this.panelCurrencyReceiver);
            this.splitContainerInput.Panel2.Controls.Add(this.panelKeyboard);
            this.splitContainerInput.Size = new System.Drawing.Size(501, 617);
            this.splitContainerInput.SplitterDistance = 211;
            this.splitContainerInput.TabIndex = 0;
            // 
            // txtDisplayInfo
            // 
            this.txtDisplayInfo.Location = new System.Drawing.Point(114, 25);
            this.txtDisplayInfo.Name = "txtDisplayInfo";
            this.txtDisplayInfo.Size = new System.Drawing.Size(292, 136);
            this.txtDisplayInfo.TabIndex = 0;
            this.txtDisplayInfo.Text = "";
            // 
            // panelBankModule
            // 
            this.panelBankModule.Controls.Add(this.cbNFC);
            this.panelBankModule.Controls.Add(this.btnEnterCard);
            this.panelBankModule.Controls.Add(this.label3);
            this.panelBankModule.Controls.Add(this.label4);
            this.panelBankModule.Controls.Add(this.cmbCardNumber);
            this.panelBankModule.Controls.Add(this.txtPinCode);
            this.panelBankModule.Location = new System.Drawing.Point(17, 211);
            this.panelBankModule.Name = "panelBankModule";
            this.panelBankModule.Size = new System.Drawing.Size(204, 163);
            this.panelBankModule.TabIndex = 18;
            // 
            // panelCurrencyReceiver
            // 
            this.panelCurrencyReceiver.Controls.Add(this.btnEnterCurrency);
            this.panelCurrencyReceiver.Controls.Add(this.label1);
            this.panelCurrencyReceiver.Controls.Add(this.label2);
            this.panelCurrencyReceiver.Controls.Add(this.cmbValuteType);
            this.panelCurrencyReceiver.Controls.Add(this.txtPar);
            this.panelCurrencyReceiver.Location = new System.Drawing.Point(17, 24);
            this.panelCurrencyReceiver.Name = "panelCurrencyReceiver";
            this.panelCurrencyReceiver.Size = new System.Drawing.Size(204, 160);
            this.panelCurrencyReceiver.TabIndex = 17;
            // 
            // btnEnterCurrency
            // 
            this.btnEnterCurrency.Location = new System.Drawing.Point(6, 120);
            this.btnEnterCurrency.Name = "btnEnterCurrency";
            this.btnEnterCurrency.Size = new System.Drawing.Size(191, 30);
            this.btnEnterCurrency.TabIndex = 17;
            this.btnEnterCurrency.Text = "Внести валюту";
            this.btnEnterCurrency.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите тип валюты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Номинал валюты:";
            // 
            // cmbValuteType
            // 
            this.cmbValuteType.FormattingEnabled = true;
            this.cmbValuteType.Location = new System.Drawing.Point(6, 31);
            this.cmbValuteType.Name = "cmbValuteType";
            this.cmbValuteType.Size = new System.Drawing.Size(191, 21);
            this.cmbValuteType.TabIndex = 13;
            // 
            // txtPar
            // 
            this.txtPar.Location = new System.Drawing.Point(6, 83);
            this.txtPar.Name = "txtPar";
            this.txtPar.Size = new System.Drawing.Size(100, 20);
            this.txtPar.TabIndex = 15;
            // 
            // panelKeyboard
            // 
            this.panelKeyboard.Controls.Add(this.btn5);
            this.panelKeyboard.Controls.Add(this.btnProduct);
            this.panelKeyboard.Controls.Add(this.btn1);
            this.panelKeyboard.Controls.Add(this.btnChange);
            this.panelKeyboard.Controls.Add(this.btn2);
            this.panelKeyboard.Controls.Add(this.btn0);
            this.panelKeyboard.Controls.Add(this.btn3);
            this.panelKeyboard.Controls.Add(this.btn9);
            this.panelKeyboard.Controls.Add(this.btn4);
            this.panelKeyboard.Controls.Add(this.btn8);
            this.panelKeyboard.Controls.Add(this.btn6);
            this.panelKeyboard.Controls.Add(this.btn7);
            this.panelKeyboard.Location = new System.Drawing.Point(277, 82);
            this.panelKeyboard.Name = "panelKeyboard";
            this.panelKeyboard.Size = new System.Drawing.Size(212, 235);
            this.panelKeyboard.TabIndex = 12;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(85, 49);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(35, 187);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(70, 40);
            this.btnProduct.TabIndex = 11;
            this.btnProduct.Text = "Товар";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(35, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(111, 187);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(68, 40);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Сдача";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(85, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(85, 141);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 40);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(135, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(135, 95);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 40);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(35, 49);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(85, 95);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 40);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(135, 49);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 40);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(35, 95);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 40);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEnterCard
            // 
            this.btnEnterCard.Location = new System.Drawing.Point(8, 127);
            this.btnEnterCard.Name = "btnEnterCard";
            this.btnEnterCard.Size = new System.Drawing.Size(191, 30);
            this.btnEnterCard.TabIndex = 22;
            this.btnEnterCard.Text = "Внести валюту";
            this.btnEnterCard.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер банковской карты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Пин код:";
            // 
            // cmbCardNumber
            // 
            this.cmbCardNumber.FormattingEnabled = true;
            this.cmbCardNumber.Location = new System.Drawing.Point(8, 38);
            this.cmbCardNumber.Name = "cmbCardNumber";
            this.cmbCardNumber.Size = new System.Drawing.Size(191, 21);
            this.cmbCardNumber.TabIndex = 18;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(8, 90);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(100, 20);
            this.txtPinCode.TabIndex = 20;
            // 
            // cbNFC
            // 
            this.cbNFC.AutoSize = true;
            this.cbNFC.Location = new System.Drawing.Point(114, 92);
            this.cbNFC.Name = "cbNFC";
            this.cbNFC.Size = new System.Drawing.Size(87, 17);
            this.cbNFC.TabIndex = 23;
            this.cbNFC.Text = "NFC-модуль";
            this.cbNFC.UseVisualStyleBackColor = true;
            this.cbNFC.CheckedChanged += new System.EventHandler(this.cbNFC_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 617);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainMenu";
            this.Text = "Автомат для продажи розничной продукции";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.splitContainerInput.Panel1.ResumeLayout(false);
            this.splitContainerInput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInput)).EndInit();
            this.splitContainerInput.ResumeLayout(false);
            this.panelBankModule.ResumeLayout(false);
            this.panelBankModule.PerformLayout();
            this.panelCurrencyReceiver.ResumeLayout(false);
            this.panelCurrencyReceiver.PerformLayout();
            this.panelKeyboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.SplitContainer splitContainerInput;
        private System.Windows.Forms.RichTextBox txtDisplayInfo;
        private System.Windows.Forms.Panel panelKeyboard;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbValuteType;
        private System.Windows.Forms.Panel panelCurrencyReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPar;
        private System.Windows.Forms.Button btnEnterCurrency;
        private System.Windows.Forms.Panel panelBankModule;
        private System.Windows.Forms.Button btnEnterCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCardNumber;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.CheckBox cbNFC;
    }
}

