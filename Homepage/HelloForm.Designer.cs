namespace Homepage
{
    partial class HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.txtChineseName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.ChineseName = new System.Windows.Forms.Label();
            this.EnglishName = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.zodiac = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChineseName
            // 
            this.txtChineseName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChineseName.Location = new System.Drawing.Point(194, 36);
            this.txtChineseName.Multiline = true;
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(132, 39);
            this.txtChineseName.TabIndex = 0;
            this.txtChineseName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(194, 171);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(132, 39);
            this.txtGender.TabIndex = 1;
            // 
            // txtZodiac
            // 
            this.txtZodiac.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtZodiac.Location = new System.Drawing.Point(194, 238);
            this.txtZodiac.Multiline = true;
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(132, 39);
            this.txtZodiac.TabIndex = 2;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishName.Location = new System.Drawing.Point(194, 102);
            this.txtEnglishName.Multiline = true;
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(132, 39);
            this.txtEnglishName.TabIndex = 3;
            // 
            // ChineseName
            // 
            this.ChineseName.BackColor = System.Drawing.Color.Transparent;
            this.ChineseName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChineseName.Location = new System.Drawing.Point(23, 36);
            this.ChineseName.Name = "ChineseName";
            this.ChineseName.Size = new System.Drawing.Size(88, 39);
            this.ChineseName.TabIndex = 4;
            this.ChineseName.Text = "姓名:";
            this.ChineseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChineseName.Click += new System.EventHandler(this.ChineseName_Click);
            // 
            // EnglishName
            // 
            this.EnglishName.BackColor = System.Drawing.Color.Transparent;
            this.EnglishName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EnglishName.Location = new System.Drawing.Point(23, 102);
            this.EnglishName.Name = "EnglishName";
            this.EnglishName.Size = new System.Drawing.Size(176, 39);
            this.EnglishName.TabIndex = 5;
            this.EnglishName.Text = "English Name:";
            this.EnglishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnglishName.Click += new System.EventHandler(this.EnglishName_Click);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gender.Location = new System.Drawing.Point(23, 170);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(88, 39);
            this.gender.TabIndex = 6;
            this.gender.Text = "性別:";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // zodiac
            // 
            this.zodiac.BackColor = System.Drawing.Color.Transparent;
            this.zodiac.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zodiac.Location = new System.Drawing.Point(23, 238);
            this.zodiac.Name = "zodiac";
            this.zodiac.Size = new System.Drawing.Size(88, 39);
            this.zodiac.TabIndex = 7;
            this.zodiac.Text = "星座:";
            this.zodiac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zodiac.Click += new System.EventHandler(this.zodiac_Click);
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(28, 298);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(137, 37);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "Say HELLO!";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(194, 298);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(132, 37);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say HI!";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(602, 407);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.zodiac);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.ChineseName);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtChineseName);
            this.Controls.Add(this.EnglishName);
            this.DoubleBuffered = true;
            this.Name = "HelloForm";
            this.Text = "你好! C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChineseName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Label ChineseName;
        private System.Windows.Forms.Label EnglishName;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label zodiac;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
    }
}

