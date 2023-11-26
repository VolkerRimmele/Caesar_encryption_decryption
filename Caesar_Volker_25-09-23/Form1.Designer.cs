namespace Caesar_Volker_25_09_23
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
            lbl_Input = new Label();
            txt_Input = new TextBox();
            lbl_Output = new Label();
            txt_Output = new TextBox();
            btn_Encrypt = new Button();
            btn_Decrypt = new Button();
            colorDialog1 = new ColorDialog();
            txt_Ent = new TextBox();
            lbl_Ent = new Label();
            lst_Box = new ListBox();
            lbl_Ver = new Label();
            btn_Ende = new Button();
            btn_FelderLeeren = new Button();
            SuspendLayout();
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Location = new Point(26, 74);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(52, 15);
            lbl_Input.TabIndex = 0;
            lbl_Input.Text = "Eingabe:";
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(118, 66);
            txt_Input.Multiline = true;
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(132, 23);
            txt_Input.TabIndex = 1;
            // 
            // lbl_Output
            // 
            lbl_Output.AutoSize = true;
            lbl_Output.Location = new Point(296, 69);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(56, 15);
            lbl_Output.TabIndex = 2;
            lbl_Output.Text = "Ausgabe:";
            // 
            // txt_Output
            // 
            txt_Output.Location = new Point(403, 66);
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(139, 23);
            txt_Output.TabIndex = 3;
            // 
            // btn_Encrypt
            // 
            btn_Encrypt.Location = new Point(118, 166);
            btn_Encrypt.Name = "btn_Encrypt";
            btn_Encrypt.Size = new Size(98, 23);
            btn_Encrypt.TabIndex = 5;
            btn_Encrypt.Text = "Verschlüsseln";
            btn_Encrypt.UseVisualStyleBackColor = true;
            btn_Encrypt.Click += btn_Encrypt_Click;
            // 
            // btn_Decrypt
            // 
            btn_Decrypt.Location = new Point(428, 166);
            btn_Decrypt.Name = "btn_Decrypt";
            btn_Decrypt.Size = new Size(98, 23);
            btn_Decrypt.TabIndex = 6;
            btn_Decrypt.Text = "Entschlüsseln";
            btn_Decrypt.UseVisualStyleBackColor = true;
            btn_Decrypt.Click += btn_Decrypt_Click;
            // 
            // txt_Ent
            // 
            txt_Ent.Location = new Point(667, 66);
            txt_Ent.Name = "txt_Ent";
            txt_Ent.Size = new Size(121, 23);
            txt_Ent.TabIndex = 7;
            // 
            // lbl_Ent
            // 
            lbl_Ent.AutoSize = true;
            lbl_Ent.Location = new Point(564, 71);
            lbl_Ent.Name = "lbl_Ent";
            lbl_Ent.Size = new Size(78, 15);
            lbl_Ent.TabIndex = 8;
            lbl_Ent.Text = "Entschlüsselt:";
            // 
            // lst_Box
            // 
            lst_Box.FormattingEnabled = true;
            lst_Box.ItemHeight = 15;
            lst_Box.Items.AddRange(new object[] { "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0", "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10" });
            lst_Box.Location = new Point(97, 267);
            lst_Box.Name = "lst_Box";
            lst_Box.Size = new Size(172, 109);
            lst_Box.TabIndex = 9;
            lst_Box.Click += lst_Box_Click;
            lst_Box.SelectedIndexChanged += lst_Box_Click;
            // 
            // lbl_Ver
            // 
            lbl_Ver.AutoSize = true;
            lbl_Ver.Location = new Point(97, 229);
            lbl_Ver.Name = "lbl_Ver";
            lbl_Ver.Size = new Size(123, 15);
            lbl_Ver.TabIndex = 10;
            lbl_Ver.Text = "Verschlüsselungsgrad:";
            // 
            // btn_Ende
            // 
            btn_Ende.Location = new Point(428, 288);
            btn_Ende.Name = "btn_Ende";
            btn_Ende.Size = new Size(147, 23);
            btn_Ende.TabIndex = 11;
            btn_Ende.Text = "Programm beenden";
            btn_Ende.UseVisualStyleBackColor = true;
            btn_Ende.Click += btn_Ende_Click;
            // 
            // btn_FelderLeeren
            // 
            btn_FelderLeeren.Location = new Point(432, 232);
            btn_FelderLeeren.Name = "btn_FelderLeeren";
            btn_FelderLeeren.Size = new Size(110, 23);
            btn_FelderLeeren.TabIndex = 12;
            btn_FelderLeeren.Text = "Felder leeren";
            btn_FelderLeeren.UseVisualStyleBackColor = true;
            btn_FelderLeeren.Click += btn_FelderLeeren_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_FelderLeeren);
            Controls.Add(btn_Ende);
            Controls.Add(lbl_Ver);
            Controls.Add(lst_Box);
            Controls.Add(lbl_Ent);
            Controls.Add(txt_Ent);
            Controls.Add(btn_Decrypt);
            Controls.Add(btn_Encrypt);
            Controls.Add(txt_Output);
            Controls.Add(lbl_Output);
            Controls.Add(txt_Input);
            Controls.Add(lbl_Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Input;
        private TextBox txt_Input;
        private Label lbl_Output;
        private TextBox txt_Output;
        private Button btn_Encrypt;
        private Button btn_Decrypt;
        private ColorDialog colorDialog1;
        private TextBox txt_Ent;
        private Label lbl_Ent;
        private ListBox lst_Box;
        private Label lbl_Ver;
        private Button btn_Ende;
        private Button btn_FelderLeeren;
    }
}