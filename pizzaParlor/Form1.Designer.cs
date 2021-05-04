
namespace pizzaParlor
{
    partial class pizzaParlor
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBlock = new System.Windows.Forms.Label();
            this.numberOfToppings = new System.Windows.Forms.Label();
            this.toppingAmount = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // titleBlock
            // 
            this.titleBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleBlock.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBlock.ForeColor = System.Drawing.Color.White;
            this.titleBlock.Location = new System.Drawing.Point(-3, 0);
            this.titleBlock.Name = "titleBlock";
            this.titleBlock.Size = new System.Drawing.Size(804, 69);
            this.titleBlock.TabIndex = 1;
            this.titleBlock.Text = "                                 Pizza Parlour";
            // 
            // numberOfToppings
            // 
            this.numberOfToppings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfToppings.ForeColor = System.Drawing.Color.White;
            this.numberOfToppings.Location = new System.Drawing.Point(61, 135);
            this.numberOfToppings.Name = "numberOfToppings";
            this.numberOfToppings.Size = new System.Drawing.Size(332, 40);
            this.numberOfToppings.TabIndex = 2;
            this.numberOfToppings.Text = "Number Of Toppings";
            // 
            // toppingAmount
            // 
            this.toppingAmount.Location = new System.Drawing.Point(378, 147);
            this.toppingAmount.Name = "toppingAmount";
            this.toppingAmount.Size = new System.Drawing.Size(45, 22);
            this.toppingAmount.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(312, 222);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(130, 44);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.White;
            this.amount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(110, 321);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(524, 97);
            this.amount.TabIndex = 5;
            // 
            // pizzaParlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toppingAmount);
            this.Controls.Add(this.numberOfToppings);
            this.Controls.Add(this.titleBlock);
            this.Controls.Add(this.label1);
            this.Name = "pizzaParlor";
            this.Text = "Pizza Parlor";
            this.Load += new System.EventHandler(this.pizzaParlor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleBlock;
        private System.Windows.Forms.Label numberOfToppings;
        private System.Windows.Forms.TextBox toppingAmount;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label amount;
    }
}

