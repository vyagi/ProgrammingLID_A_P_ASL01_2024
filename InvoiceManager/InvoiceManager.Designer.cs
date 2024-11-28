namespace InvoiceManager
{
    partial class InvoiceManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pathLabel = new Label();
            pathTextBox = new TextBox();
            displayButton = new Button();
            byCategoryButton = new Button();
            resultTextBox = new TextBox();
            byMonthButton = new Button();
            SuspendLayout();
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(15, 16);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(31, 15);
            pathLabel.TabIndex = 0;
            pathLabel.Text = "Path";
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(64, 12);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(472, 23);
            pathTextBox.TabIndex = 1;
            pathTextBox.Text = "C:\\Users\\mjagiela\\Desktop\\Invoices.txt";
            // 
            // displayButton
            // 
            displayButton.Location = new Point(15, 57);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(75, 23);
            displayButton.TabIndex = 2;
            displayButton.Text = "Display";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // byCategoryButton
            // 
            byCategoryButton.Location = new Point(96, 57);
            byCategoryButton.Name = "byCategoryButton";
            byCategoryButton.Size = new Size(81, 23);
            byCategoryButton.TabIndex = 3;
            byCategoryButton.Text = "By category";
            byCategoryButton.UseVisualStyleBackColor = true;
            byCategoryButton.Click += byCategoryButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(15, 96);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(588, 342);
            resultTextBox.TabIndex = 4;
            // 
            // byMonthButton
            // 
            byMonthButton.Location = new Point(183, 57);
            byMonthButton.Name = "byMonthButton";
            byMonthButton.Size = new Size(75, 23);
            byMonthButton.TabIndex = 5;
            byMonthButton.Text = "By month";
            byMonthButton.UseVisualStyleBackColor = true;
            byMonthButton.Click += byMonthButton_Click;
            // 
            // InvoiceManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(byMonthButton);
            Controls.Add(resultTextBox);
            Controls.Add(byCategoryButton);
            Controls.Add(displayButton);
            Controls.Add(pathTextBox);
            Controls.Add(pathLabel);
            Name = "InvoiceManager";
            Text = "Invoice manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pathLabel;
        private TextBox pathTextBox;
        private Button displayButton;
        private Button byCategoryButton;
        private TextBox resultTextBox;
        private Button byMonthButton;
    }
}
