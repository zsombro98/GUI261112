namespace GUI261112
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
            txtbox = new TextBox();
            list_items = new ListBox();
            add_item = new Button();
            clear = new Button();
            clear_all = new Button();
            SuspendLayout();
            // 
            // txtbox
            // 
            txtbox.Location = new Point(22, 104);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(327, 23);
            txtbox.TabIndex = 0;
            txtbox.TextChanged += txtbox_TextChanged;
            // 
            // list_items
            // 
            list_items.FormattingEnabled = true;
            list_items.Location = new Point(36, 203);
            list_items.Name = "list_items";
            list_items.Size = new Size(266, 229);
            list_items.TabIndex = 1;
            // 
            // add_item
            // 
            add_item.Location = new Point(116, 154);
            add_item.Name = "add_item";
            add_item.Size = new Size(119, 25);
            add_item.TabIndex = 2;
            add_item.Text = "hozzaadas";
            add_item.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            clear.Location = new Point(22, 463);
            clear.Name = "clear";
            clear.Size = new Size(117, 31);
            clear.TabIndex = 3;
            clear.Text = "torles";
            clear.UseVisualStyleBackColor = true;
            // 
            // clear_all
            // 
            clear_all.Location = new Point(208, 463);
            clear_all.Name = "clear_all";
            clear_all.Size = new Size(124, 31);
            clear_all.TabIndex = 4;
            clear_all.Text = "ossze torles";
            clear_all.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 536);
            Controls.Add(clear_all);
            Controls.Add(clear);
            Controls.Add(add_item);
            Controls.Add(list_items);
            Controls.Add(txtbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox;
        private ListBox list_items;
        private Button add_item;
        private Button clear;
        private Button clear_all;
    }
}
