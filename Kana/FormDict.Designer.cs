namespace Kana
{
    partial class FormDict
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            textBoxKana = new System.Windows.Forms.TextBox();
            textBoxRoma = new System.Windows.Forms.TextBox();
            buttonCopyKana = new System.Windows.Forms.Button();
            buttonCopyRoma = new System.Windows.Forms.Button();
            buttonPasteRoma = new System.Windows.Forms.Button();
            buttonPasteKana = new System.Windows.Forms.Button();
            checkBoxKatakana = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // textBoxKana
            // 
            textBoxKana.Location = new System.Drawing.Point(14, 17);
            textBoxKana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBoxKana.Name = "textBoxKana";
            textBoxKana.Size = new System.Drawing.Size(228, 23);
            textBoxKana.TabIndex = 0;
            textBoxKana.TextChanged += TextBoxKana_TextChanged;
            // 
            // textBoxRoma
            // 
            textBoxRoma.Location = new System.Drawing.Point(14, 57);
            textBoxRoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBoxRoma.Name = "textBoxRoma";
            textBoxRoma.Size = new System.Drawing.Size(228, 23);
            textBoxRoma.TabIndex = 1;
            textBoxRoma.TextChanged += TextBoxRoma_TextChanged;
            // 
            // buttonCopyKana
            // 
            buttonCopyKana.Location = new System.Drawing.Point(251, 14);
            buttonCopyKana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonCopyKana.Name = "buttonCopyKana";
            buttonCopyKana.Size = new System.Drawing.Size(66, 33);
            buttonCopyKana.TabIndex = 3;
            buttonCopyKana.Text = "Copy";
            buttonCopyKana.UseVisualStyleBackColor = true;
            buttonCopyKana.Click += ButtonCopyKana_Click;
            // 
            // buttonCopyRoma
            // 
            buttonCopyRoma.Location = new System.Drawing.Point(251, 57);
            buttonCopyRoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonCopyRoma.Name = "buttonCopyRoma";
            buttonCopyRoma.Size = new System.Drawing.Size(66, 33);
            buttonCopyRoma.TabIndex = 4;
            buttonCopyRoma.Text = "Copy";
            buttonCopyRoma.UseVisualStyleBackColor = true;
            buttonCopyRoma.Click += ButtonCopyRoma_Click;
            // 
            // buttonPasteRoma
            // 
            buttonPasteRoma.Location = new System.Drawing.Point(324, 57);
            buttonPasteRoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonPasteRoma.Name = "buttonPasteRoma";
            buttonPasteRoma.Size = new System.Drawing.Size(66, 33);
            buttonPasteRoma.TabIndex = 6;
            buttonPasteRoma.Text = "Paste";
            buttonPasteRoma.UseVisualStyleBackColor = true;
            buttonPasteRoma.Click += ButtonPasteRoma_Click;
            // 
            // buttonPasteKana
            // 
            buttonPasteKana.Location = new System.Drawing.Point(324, 14);
            buttonPasteKana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonPasteKana.Name = "buttonPasteKana";
            buttonPasteKana.Size = new System.Drawing.Size(66, 33);
            buttonPasteKana.TabIndex = 5;
            buttonPasteKana.Text = "Paste";
            buttonPasteKana.UseVisualStyleBackColor = true;
            buttonPasteKana.Click += ButtonPasteKana_Click;
            // 
            // checkBoxKatakana
            // 
            checkBoxKatakana.AutoSize = true;
            checkBoxKatakana.Location = new System.Drawing.Point(14, 95);
            checkBoxKatakana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            checkBoxKatakana.Name = "checkBoxKatakana";
            checkBoxKatakana.Size = new System.Drawing.Size(139, 21);
            checkBoxKatakana.TabIndex = 7;
            checkBoxKatakana.Text = "Katakana/Hiragana";
            checkBoxKatakana.UseVisualStyleBackColor = true;
            checkBoxKatakana.CheckedChanged += CheckBoxKatakana_CheckedChanged;
            // 
            // FormDict
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(401, 143);
            Controls.Add(checkBoxKatakana);
            Controls.Add(buttonPasteRoma);
            Controls.Add(buttonPasteKana);
            Controls.Add(buttonCopyRoma);
            Controls.Add(buttonCopyKana);
            Controls.Add(textBoxRoma);
            Controls.Add(textBoxKana);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(417, 182);
            MinimumSize = new System.Drawing.Size(417, 182);
            Name = "FormDict";
            Text = "Kana Dict";
            Load += FormDict_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKana;
        private System.Windows.Forms.TextBox textBoxRoma;
        private System.Windows.Forms.Button buttonCopyKana;
        private System.Windows.Forms.Button buttonCopyRoma;
        private System.Windows.Forms.Button buttonPasteRoma;
        private System.Windows.Forms.Button buttonPasteKana;
        private System.Windows.Forms.CheckBox checkBoxKatakana;
    }
}

