namespace TextToSpeech
{
    partial class MainForm
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
            label1 = new Label();
            txtText = new TextBox();
            btnSpeech = new Button();
            ddlVoiceNames = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // txtText
            // 
            txtText.Location = new Point(5, 43);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(783, 361);
            txtText.TabIndex = 1;
            // 
            // btnSpeech
            // 
            btnSpeech.Location = new Point(689, 410);
            btnSpeech.Name = "btnSpeech";
            btnSpeech.Size = new Size(99, 29);
            btnSpeech.TabIndex = 2;
            btnSpeech.Text = "Speech";
            btnSpeech.UseVisualStyleBackColor = true;
            btnSpeech.Click += btnSpeech_Click;
            // 
            // ddlVoiceNames
            // 
            ddlVoiceNames.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlVoiceNames.FormattingEnabled = true;
            ddlVoiceNames.Location = new Point(594, 9);
            ddlVoiceNames.Name = "ddlVoiceNames";
            ddlVoiceNames.Size = new Size(194, 28);
            ddlVoiceNames.TabIndex = 3;
            ddlVoiceNames.SelectedIndexChanged += ddlVoiceNames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 12);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Speaker";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ddlVoiceNames);
            Controls.Add(btnSpeech);
            Controls.Add(txtText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Simple Text to Speach (Experimental)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtText;
        private Button btnSpeech;
        private ComboBox ddlVoiceNames;
        private Label label2;
    }
}
