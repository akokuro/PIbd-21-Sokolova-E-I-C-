namespace WindowsFormsCars
{
    partial class FormShipConfig
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
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelLiner = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxConfig.Location = new System.Drawing.Point(60, 3);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(256, 138);
            this.pictureBoxConfig.TabIndex = 0;
            this.pictureBoxConfig.TabStop = false;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelLiner);
            this.groupBoxConfig.Controls.Add(this.labelShip);
            this.groupBoxConfig.Location = new System.Drawing.Point(35, 62);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(151, 176);
            this.groupBoxConfig.TabIndex = 1;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Выбор корабля";
            // 
            // labelLiner
            // 
            this.labelLiner.AllowDrop = true;
            this.labelLiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLiner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLiner.Location = new System.Drawing.Point(6, 101);
            this.labelLiner.Name = "labelLiner";
            this.labelLiner.Size = new System.Drawing.Size(134, 57);
            this.labelLiner.TabIndex = 1;
            this.labelLiner.Text = "Лайнер";
            this.labelLiner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLiner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLiner_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.AllowDrop = true;
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShip.Location = new System.Drawing.Point(7, 28);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(134, 57);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(214, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 217);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(118, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дополнительный цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(118, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Основной цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelPink);
            this.groupBox1.Controls.Add(this.panelBlue);
            this.groupBox1.Controls.Add(this.panelAqua);
            this.groupBox1.Controls.Add(this.panelGreen);
            this.groupBox1.Controls.Add(this.panelOrange);
            this.groupBox1.Controls.Add(this.panelYellow);
            this.groupBox1.Controls.Add(this.panelRed);
            this.groupBox1.Controls.Add(this.panelBlack);
            this.groupBox1.Location = new System.Drawing.Point(626, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвета";
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.DeepPink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(108, 180);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(40, 40);
            this.panelPink.TabIndex = 11;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(26, 180);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 10;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(108, 125);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(40, 40);
            this.panelAqua.TabIndex = 10;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Chartreuse;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(26, 125);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 11;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(26, 78);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 9;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(108, 78);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 9;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(108, 20);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 10;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(26, 20);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 8;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 252);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 26);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(92, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 25);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "FormShipConfig";
            this.Text = "FormShipConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Label labelLiner;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlack;
    }
}