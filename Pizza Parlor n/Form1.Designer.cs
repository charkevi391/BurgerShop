namespace Pizza_Parlor_n
{
    partial class BigBurgerBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigBurgerBar));
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.MaskedTextBox();
            this.drinkBox = new System.Windows.Forms.MaskedTextBox();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tendLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(187, 34);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(100, 20);
            this.burgerBox.TabIndex = 0;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(187, 85);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(100, 20);
            this.friesBox.TabIndex = 1;
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(187, 137);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(100, 20);
            this.drinkBox.TabIndex = 2;
            this.drinkBox.ValidatingType = typeof(int);
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Location = new System.Drawing.Point(47, 34);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(43, 13);
            this.burgerLabel.TabIndex = 3;
            this.burgerLabel.Text = "Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Location = new System.Drawing.Point(47, 88);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(29, 13);
            this.friesLabel.TabIndex = 4;
            this.friesLabel.Text = "Fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(47, 144);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(37, 13);
            this.drinksLabel.TabIndex = 5;
            this.drinksLabel.Text = "Drinks";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(358, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(158, 25);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Big Burger Bar ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(80, 177);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(153, 24);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(47, 227);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(53, 13);
            this.subLabel.TabIndex = 8;
            this.subLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(47, 281);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(47, 330);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // subOutput
            // 
            this.subOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.subOutput.Location = new System.Drawing.Point(203, 227);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(100, 23);
            this.subOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.taxOutput.Location = new System.Drawing.Point(203, 281);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalOutput.Location = new System.Drawing.Point(203, 330);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(12, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 11);
            this.label11.TabIndex = 14;
            // 
            // tendLabel
            // 
            this.tendLabel.AutoSize = true;
            this.tendLabel.Location = new System.Drawing.Point(47, 404);
            this.tendLabel.Name = "tendLabel";
            this.tendLabel.Size = new System.Drawing.Size(53, 13);
            this.tendLabel.TabIndex = 15;
            this.tendLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(187, 397);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedBox.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(80, 436);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(153, 23);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change ";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(47, 473);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeOutput.Location = new System.Drawing.Point(203, 473);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 19;
            // 
            // reciptButton
            // 
            this.reciptButton.Location = new System.Drawing.Point(15, 515);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(288, 23);
            this.reciptButton.TabIndex = 20;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(95, 9);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(102, 13);
            this.valueLabel.TabIndex = 21;
            this.valueLabel.Text = "Has to be a # Value";
            this.valueLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Image = global::Pizza_Parlor_n.Properties.Resources.burg;
            this.label1.Location = new System.Drawing.Point(309, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 193);
            this.label1.TabIndex = 22;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(399, 78);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 23;
            this.orderButton.Text = "New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // BigBurgerBar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 550);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tendLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.burgerBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BigBurgerBar";
            this.Text = "Big Burger Bar ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.MaskedTextBox friesBox;
        private System.Windows.Forms.MaskedTextBox drinkBox;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tendLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderButton;
    }
}

