namespace przegladarkaObrazow
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnPoprzednie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCzas = new System.Windows.Forms.ComboBox();
            this.btnPokazSlajdow = new System.Windows.Forms.Button();
            this.btnObrocPrawo = new System.Windows.Forms.Button();
            this.btnObrotLewo = new System.Windows.Forms.Button();
            this.btnNastepne = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoprzednie
            // 
            this.btnPoprzednie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPoprzednie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoprzednie.Enabled = false;
            this.btnPoprzednie.Image = global::przegladarkaObrazow.Properties.Resources.previous;
            this.btnPoprzednie.Location = new System.Drawing.Point(378, 17);
            this.btnPoprzednie.Name = "btnPoprzednie";
            this.btnPoprzednie.Size = new System.Drawing.Size(75, 36);
            this.btnPoprzednie.TabIndex = 2;
            this.btnPoprzednie.UseVisualStyleBackColor = true;
            this.btnPoprzednie.Click += new System.EventHandler(this.btnPoprzednie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.comboCzas);
            this.panel1.Controls.Add(this.btnPokazSlajdow);
            this.panel1.Controls.Add(this.btnObrocPrawo);
            this.panel1.Controls.Add(this.btnObrotLewo);
            this.panel1.Controls.Add(this.btnNastepne);
            this.panel1.Controls.Add(this.btnWczytaj);
            this.panel1.Controls.Add(this.btnPoprzednie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 65);
            this.panel1.TabIndex = 4;
            // 
            // comboCzas
            // 
            this.comboCzas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboCzas.FormattingEnabled = true;
            this.comboCzas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboCzas.Location = new System.Drawing.Point(702, 19);
            this.comboCzas.Name = "comboCzas";
            this.comboCzas.Size = new System.Drawing.Size(50, 32);
            this.comboCzas.TabIndex = 6;
            this.comboCzas.Text = "5";
            this.comboCzas.Visible = false;
            this.comboCzas.SelectedIndexChanged += new System.EventHandler(this.comboCzas_SelectedIndexChanged);
            // 
            // btnPokazSlajdow
            // 
            this.btnPokazSlajdow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokazSlajdow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPokazSlajdow.Enabled = false;
            this.btnPokazSlajdow.Image = global::przegladarkaObrazow.Properties.Resources.play;
            this.btnPokazSlajdow.Location = new System.Drawing.Point(621, 17);
            this.btnPokazSlajdow.MaximumSize = new System.Drawing.Size(400, 200);
            this.btnPokazSlajdow.Name = "btnPokazSlajdow";
            this.btnPokazSlajdow.Size = new System.Drawing.Size(75, 36);
            this.btnPokazSlajdow.TabIndex = 5;
            this.btnPokazSlajdow.UseVisualStyleBackColor = true;
            this.btnPokazSlajdow.Click += new System.EventHandler(this.btnPokazSlajdow_Click);
            // 
            // btnObrocPrawo
            // 
            this.btnObrocPrawo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrocPrawo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObrocPrawo.Enabled = false;
            this.btnObrocPrawo.Image = global::przegladarkaObrazow.Properties.Resources.rotateRight;
            this.btnObrocPrawo.Location = new System.Drawing.Point(297, 17);
            this.btnObrocPrawo.Name = "btnObrocPrawo";
            this.btnObrocPrawo.Size = new System.Drawing.Size(75, 36);
            this.btnObrocPrawo.TabIndex = 1;
            this.btnObrocPrawo.UseVisualStyleBackColor = true;
            this.btnObrocPrawo.Click += new System.EventHandler(this.btnObrocPrawo_Click);
            // 
            // btnObrotLewo
            // 
            this.btnObrotLewo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrotLewo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObrotLewo.Enabled = false;
            this.btnObrotLewo.Image = global::przegladarkaObrazow.Properties.Resources.rotateLeft;
            this.btnObrotLewo.Location = new System.Drawing.Point(216, 17);
            this.btnObrotLewo.Name = "btnObrotLewo";
            this.btnObrotLewo.Size = new System.Drawing.Size(75, 36);
            this.btnObrotLewo.TabIndex = 0;
            this.btnObrotLewo.UseVisualStyleBackColor = true;
            this.btnObrotLewo.Click += new System.EventHandler(this.btnObrotLewo_Click);
            // 
            // btnNastepne
            // 
            this.btnNastepne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNastepne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNastepne.Enabled = false;
            this.btnNastepne.Image = global::przegladarkaObrazow.Properties.Resources.next;
            this.btnNastepne.Location = new System.Drawing.Point(540, 17);
            this.btnNastepne.Name = "btnNastepne";
            this.btnNastepne.Size = new System.Drawing.Size(75, 36);
            this.btnNastepne.TabIndex = 4;
            this.btnNastepne.UseVisualStyleBackColor = true;
            this.btnNastepne.Click += new System.EventHandler(this.btnNastepne_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.AccessibleDescription = "";
            this.btnWczytaj.AccessibleName = "";
            this.btnWczytaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWczytaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWczytaj.Image = global::przegladarkaObrazow.Properties.Resources.pictures;
            this.btnWczytaj.Location = new System.Drawing.Point(459, 17);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 36);
            this.btnWczytaj.TabIndex = 3;
            this.btnWczytaj.Tag = "";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 545);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1008, 545);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przeglądarka Zdjęć";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Klawiatura_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNastepne;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnObrotLewo;
        private System.Windows.Forms.Button btnObrocPrawo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPokazSlajdow;
        private System.Windows.Forms.ComboBox comboCzas;
        private System.Windows.Forms.Button btnPoprzednie;
    }
}

