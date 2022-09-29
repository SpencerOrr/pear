namespace pear
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoLabel = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.galaLabel = new System.Windows.Forms.Label();
            this.grannySmithLabel = new System.Windows.Forms.Label();
            this.honeyCrispLabel = new System.Windows.Forms.Label();
            this.galaInput = new System.Windows.Forms.TextBox();
            this.grannySmithInput = new System.Windows.Forms.TextBox();
            this.honeycrispInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeInput = new System.Windows.Forms.TextBox();
            this.recipteTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.logoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoLabel.Location = new System.Drawing.Point(1, -2);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(492, 44);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Pear";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.receiptOutput.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptOutput.Location = new System.Drawing.Point(276, 42);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(217, 397);
            this.receiptOutput.TabIndex = 1;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.printButton.Location = new System.Drawing.Point(64, 463);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(129, 36);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrderButton.Location = new System.Drawing.Point(326, 463);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(129, 36);
            this.newOrderButton.TabIndex = 3;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            // 
            // galaLabel
            // 
            this.galaLabel.AutoSize = true;
            this.galaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.galaLabel.Location = new System.Drawing.Point(13, 69);
            this.galaLabel.Name = "galaLabel";
            this.galaLabel.Size = new System.Drawing.Size(117, 18);
            this.galaLabel.TabIndex = 4;
            this.galaLabel.Text = "Number of Gala ";
            // 
            // grannySmithLabel
            // 
            this.grannySmithLabel.AutoSize = true;
            this.grannySmithLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grannySmithLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grannySmithLabel.Location = new System.Drawing.Point(13, 132);
            this.grannySmithLabel.Name = "grannySmithLabel";
            this.grannySmithLabel.Size = new System.Drawing.Size(170, 18);
            this.grannySmithLabel.TabIndex = 5;
            this.grannySmithLabel.Text = "Number of Granny smith";
            // 
            // honeyCrispLabel
            // 
            this.honeyCrispLabel.AutoSize = true;
            this.honeyCrispLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honeyCrispLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.honeyCrispLabel.Location = new System.Drawing.Point(13, 100);
            this.honeyCrispLabel.Name = "honeyCrispLabel";
            this.honeyCrispLabel.Size = new System.Drawing.Size(157, 18);
            this.honeyCrispLabel.TabIndex = 6;
            this.honeyCrispLabel.Text = "Number of Honeycrisp";
            // 
            // galaInput
            // 
            this.galaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galaInput.Location = new System.Drawing.Point(192, 69);
            this.galaInput.Name = "galaInput";
            this.galaInput.Size = new System.Drawing.Size(78, 24);
            this.galaInput.TabIndex = 7;
            this.galaInput.Text = "0";
            // 
            // grannySmithInput
            // 
            this.grannySmithInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grannySmithInput.Location = new System.Drawing.Point(192, 132);
            this.grannySmithInput.Name = "grannySmithInput";
            this.grannySmithInput.Size = new System.Drawing.Size(78, 24);
            this.grannySmithInput.TabIndex = 8;
            this.grannySmithInput.Text = "0";
            // 
            // honeycrispInput
            // 
            this.honeycrispInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honeycrispInput.Location = new System.Drawing.Point(192, 100);
            this.honeycrispInput.Name = "honeycrispInput";
            this.honeycrispInput.Size = new System.Drawing.Size(78, 24);
            this.honeycrispInput.TabIndex = 9;
            this.honeycrispInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Location = new System.Drawing.Point(64, 175);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(129, 31);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subTotalLabel.Location = new System.Drawing.Point(12, 227);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(71, 18);
            this.subTotalLabel.TabIndex = 11;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalLabel.Location = new System.Drawing.Point(13, 286);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 18);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.taxLabel.Location = new System.Drawing.Point(13, 256);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(32, 18);
            this.taxLabel.TabIndex = 13;
            this.taxLabel.Text = "Tax";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(16, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 14;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(192, 227);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(78, 18);
            this.subTotalOutput.TabIndex = 15;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(192, 286);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(78, 18);
            this.totalOutput.TabIndex = 16;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(192, 256);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(78, 18);
            this.taxOutput.TabIndex = 17;
            this.taxOutput.UseMnemonic = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.Location = new System.Drawing.Point(53, 374);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(152, 31);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tenderedLabel.Location = new System.Drawing.Point(18, 343);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(70, 18);
            this.tenderedLabel.TabIndex = 19;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeLabel.Location = new System.Drawing.Point(18, 421);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(59, 18);
            this.changeLabel.TabIndex = 21;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(192, 421);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(78, 18);
            this.changeOutput.TabIndex = 22;
            // 
            // changeInput
            // 
            this.changeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeInput.Location = new System.Drawing.Point(195, 340);
            this.changeInput.Name = "changeInput";
            this.changeInput.Size = new System.Drawing.Size(78, 24);
            this.changeInput.TabIndex = 23;
            // 
            // recipteTitle
            // 
            this.recipteTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.recipteTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recipteTitle.Location = new System.Drawing.Point(276, 42);
            this.recipteTitle.Name = "recipteTitle";
            this.recipteTitle.Size = new System.Drawing.Size(217, 45);
            this.recipteTitle.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(491, 509);
            this.Controls.Add(this.recipteTitle);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.honeycrispInput);
            this.Controls.Add(this.grannySmithInput);
            this.Controls.Add(this.galaInput);
            this.Controls.Add(this.honeyCrispLabel);
            this.Controls.Add(this.grannySmithLabel);
            this.Controls.Add(this.galaLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.logoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Pear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label galaLabel;
        private System.Windows.Forms.Label grannySmithLabel;
        private System.Windows.Forms.Label honeyCrispLabel;
        private System.Windows.Forms.TextBox galaInput;
        private System.Windows.Forms.TextBox grannySmithInput;
        private System.Windows.Forms.TextBox honeycrispInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox changeInput;
        private System.Windows.Forms.Label recipteTitle;
    }
}

