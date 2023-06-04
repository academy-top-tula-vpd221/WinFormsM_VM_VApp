namespace WinFormsM_VM_VApp
{
    partial class Form1
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
            employesListBox = new ListBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            removeButton = new Button();
            addButton = new Button();
            birthDayPicker = new DateTimePicker();
            label2 = new Label();
            editButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // employesListBox
            // 
            employesListBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            employesListBox.FormattingEnabled = true;
            employesListBox.ItemHeight = 30;
            employesListBox.Location = new Point(12, 12);
            employesListBox.Name = "employesListBox";
            employesListBox.Size = new Size(251, 424);
            employesListBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(17, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(464, 36);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(birthDayPicker);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(283, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 424);
            panel1.TabIndex = 3;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(17, 335);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(228, 55);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove Employee";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(17, 213);
            addButton.Name = "addButton";
            addButton.Size = new Size(228, 55);
            addButton.TabIndex = 4;
            addButton.Text = "Add Employee";
            addButton.UseVisualStyleBackColor = true;
            // 
            // birthDayPicker
            // 
            birthDayPicker.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            birthDayPicker.Location = new Point(17, 147);
            birthDayPicker.MaxDate = new DateTime(2130, 1, 1, 0, 0, 0, 0);
            birthDayPicker.MinDate = new DateTime(1907, 1, 1, 0, 0, 0, 0);
            birthDayPicker.Name = "birthDayPicker";
            birthDayPicker.Size = new Size(464, 36);
            birthDayPicker.TabIndex = 3;
            birthDayPicker.Value = new DateTime(2023, 6, 4, 15, 22, 13, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 2;
            label2.Text = "Date of born";
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.Location = new Point(17, 274);
            editButton.Name = "editButton";
            editButton.Size = new Size(228, 55);
            editButton.TabIndex = 4;
            editButton.Text = "Edit Employee";
            editButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(employesListBox);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox employesListBox;
        private TextBox nameTextBox;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button addButton;
        private DateTimePicker birthDayPicker;
        private Button removeButton;
        private Button editButton;
    }
}