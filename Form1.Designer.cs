namespace Kalkulacka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vysledek = new System.Windows.Forms.TextBox();
            this.buttonNula = new System.Windows.Forms.Button();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonCtyri = new System.Windows.Forms.Button();
            this.buttonCarka = new System.Windows.Forms.Button();
            this.buttonTri = new System.Windows.Forms.Button();
            this.buttonDva = new System.Windows.Forms.Button();
            this.buttonJedna = new System.Windows.Forms.Button();
            this.buttonSest = new System.Windows.Forms.Button();
            this.buttonSedum = new System.Windows.Forms.Button();
            this.buttonOsm = new System.Windows.Forms.Button();
            this.buttonDevet = new System.Windows.Forms.Button();
            this.buttonDeleni = new System.Windows.Forms.Button();
            this.buttonRovnase = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonNasobeni = new System.Windows.Forms.Button();
            this.buttonSmazatVstup = new System.Windows.Forms.Button();
            this.buttonSmazatVse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vysledek
            // 
            this.vysledek.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledek.Location = new System.Drawing.Point(11, 22);
            this.vysledek.Name = "vysledek";
            this.vysledek.Size = new System.Drawing.Size(249, 31);
            this.vysledek.TabIndex = 0;
            // 
            // buttonNula
            // 
            this.buttonNula.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNula.Location = new System.Drawing.Point(11, 222);
            this.buttonNula.Name = "buttonNula";
            this.buttonNula.Size = new System.Drawing.Size(96, 45);
            this.buttonNula.TabIndex = 1;
            this.buttonNula.Text = "0";
            this.buttonNula.UseVisualStyleBackColor = true;
            this.buttonNula.Click += new System.EventHandler(this.button_click);
            // 
            // buttonPet
            // 
            this.buttonPet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPet.Location = new System.Drawing.Point(62, 120);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(45, 45);
            this.buttonPet.TabIndex = 2;
            this.buttonPet.Text = "5";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.button_click);
            // 
            // buttonCtyri
            // 
            this.buttonCtyri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCtyri.Location = new System.Drawing.Point(11, 120);
            this.buttonCtyri.Name = "buttonCtyri";
            this.buttonCtyri.Size = new System.Drawing.Size(45, 45);
            this.buttonCtyri.TabIndex = 3;
            this.buttonCtyri.Text = "4";
            this.buttonCtyri.UseVisualStyleBackColor = true;
            this.buttonCtyri.Click += new System.EventHandler(this.button_click);
            // 
            // buttonCarka
            // 
            this.buttonCarka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCarka.Location = new System.Drawing.Point(113, 222);
            this.buttonCarka.Name = "buttonCarka";
            this.buttonCarka.Size = new System.Drawing.Size(45, 45);
            this.buttonCarka.TabIndex = 4;
            this.buttonCarka.Text = ",";
            this.buttonCarka.UseVisualStyleBackColor = true;
            // 
            // buttonTri
            // 
            this.buttonTri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTri.Location = new System.Drawing.Point(113, 171);
            this.buttonTri.Name = "buttonTri";
            this.buttonTri.Size = new System.Drawing.Size(45, 45);
            this.buttonTri.TabIndex = 5;
            this.buttonTri.Text = "3";
            this.buttonTri.UseVisualStyleBackColor = true;
            this.buttonTri.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDva
            // 
            this.buttonDva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDva.Location = new System.Drawing.Point(62, 171);
            this.buttonDva.Name = "buttonDva";
            this.buttonDva.Size = new System.Drawing.Size(45, 45);
            this.buttonDva.TabIndex = 6;
            this.buttonDva.Text = "2";
            this.buttonDva.UseVisualStyleBackColor = true;
            this.buttonDva.Click += new System.EventHandler(this.button_click);
            // 
            // buttonJedna
            // 
            this.buttonJedna.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJedna.Location = new System.Drawing.Point(11, 171);
            this.buttonJedna.Name = "buttonJedna";
            this.buttonJedna.Size = new System.Drawing.Size(45, 45);
            this.buttonJedna.TabIndex = 7;
            this.buttonJedna.Text = "1";
            this.buttonJedna.UseVisualStyleBackColor = true;
            this.buttonJedna.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSest
            // 
            this.buttonSest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSest.Location = new System.Drawing.Point(113, 118);
            this.buttonSest.Name = "buttonSest";
            this.buttonSest.Size = new System.Drawing.Size(45, 45);
            this.buttonSest.TabIndex = 8;
            this.buttonSest.Text = "6";
            this.buttonSest.UseVisualStyleBackColor = true;
            this.buttonSest.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSedum
            // 
            this.buttonSedum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSedum.Location = new System.Drawing.Point(11, 69);
            this.buttonSedum.Name = "buttonSedum";
            this.buttonSedum.Size = new System.Drawing.Size(45, 45);
            this.buttonSedum.TabIndex = 9;
            this.buttonSedum.Text = "7";
            this.buttonSedum.UseVisualStyleBackColor = true;
            this.buttonSedum.Click += new System.EventHandler(this.button_click);
            // 
            // buttonOsm
            // 
            this.buttonOsm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOsm.Location = new System.Drawing.Point(62, 69);
            this.buttonOsm.Name = "buttonOsm";
            this.buttonOsm.Size = new System.Drawing.Size(45, 45);
            this.buttonOsm.TabIndex = 10;
            this.buttonOsm.Text = "8";
            this.buttonOsm.UseVisualStyleBackColor = true;
            this.buttonOsm.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDevet
            // 
            this.buttonDevet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDevet.Location = new System.Drawing.Point(113, 69);
            this.buttonDevet.Name = "buttonDevet";
            this.buttonDevet.Size = new System.Drawing.Size(45, 45);
            this.buttonDevet.TabIndex = 11;
            this.buttonDevet.Text = "9";
            this.buttonDevet.UseVisualStyleBackColor = true;
            this.buttonDevet.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDeleni
            // 
            this.buttonDeleni.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleni.Location = new System.Drawing.Point(164, 69);
            this.buttonDeleni.Name = "buttonDeleni";
            this.buttonDeleni.Size = new System.Drawing.Size(45, 45);
            this.buttonDeleni.TabIndex = 12;
            this.buttonDeleni.Text = "/";
            this.buttonDeleni.UseVisualStyleBackColor = true;
            this.buttonDeleni.Click += new System.EventHandler(this.funkce_click);
            // 
            // buttonRovnase
            // 
            this.buttonRovnase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRovnase.Location = new System.Drawing.Point(215, 171);
            this.buttonRovnase.Name = "buttonRovnase";
            this.buttonRovnase.Size = new System.Drawing.Size(45, 96);
            this.buttonRovnase.TabIndex = 13;
            this.buttonRovnase.Text = "=";
            this.buttonRovnase.UseVisualStyleBackColor = true;
            this.buttonRovnase.Click += new System.EventHandler(this.buttonRovnase_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlus.Location = new System.Drawing.Point(164, 222);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 45);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.funkce_click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinus.Location = new System.Drawing.Point(164, 171);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 45);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.funkce_click);
            // 
            // buttonNasobeni
            // 
            this.buttonNasobeni.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNasobeni.Location = new System.Drawing.Point(164, 120);
            this.buttonNasobeni.Name = "buttonNasobeni";
            this.buttonNasobeni.Size = new System.Drawing.Size(45, 45);
            this.buttonNasobeni.TabIndex = 16;
            this.buttonNasobeni.Text = "*";
            this.buttonNasobeni.UseVisualStyleBackColor = true;
            this.buttonNasobeni.Click += new System.EventHandler(this.funkce_click);
            // 
            // buttonSmazatVstup
            // 
            this.buttonSmazatVstup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSmazatVstup.Location = new System.Drawing.Point(215, 69);
            this.buttonSmazatVstup.Name = "buttonSmazatVstup";
            this.buttonSmazatVstup.Size = new System.Drawing.Size(45, 45);
            this.buttonSmazatVstup.TabIndex = 17;
            this.buttonSmazatVstup.Text = "CE";
            this.buttonSmazatVstup.UseVisualStyleBackColor = true;
            this.buttonSmazatVstup.Click += new System.EventHandler(this.ButtonVymazatVse_Click);
            // 
            // buttonSmazatVse
            // 
            this.buttonSmazatVse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSmazatVse.Location = new System.Drawing.Point(215, 120);
            this.buttonSmazatVse.Name = "buttonSmazatVse";
            this.buttonSmazatVse.Size = new System.Drawing.Size(45, 45);
            this.buttonSmazatVse.TabIndex = 18;
            this.buttonSmazatVse.Text = "C";
            this.buttonSmazatVse.UseVisualStyleBackColor = true;
            this.buttonSmazatVse.Click += new System.EventHandler(this.buttonSmazatVse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 283);
            this.Controls.Add(this.buttonSmazatVse);
            this.Controls.Add(this.buttonSmazatVstup);
            this.Controls.Add(this.buttonNasobeni);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonRovnase);
            this.Controls.Add(this.buttonDeleni);
            this.Controls.Add(this.buttonDevet);
            this.Controls.Add(this.buttonOsm);
            this.Controls.Add(this.buttonSedum);
            this.Controls.Add(this.buttonSest);
            this.Controls.Add(this.buttonJedna);
            this.Controls.Add(this.buttonDva);
            this.Controls.Add(this.buttonTri);
            this.Controls.Add(this.buttonCarka);
            this.Controls.Add(this.buttonCtyri);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.buttonNula);
            this.Controls.Add(this.vysledek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulačka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vysledek;
        private System.Windows.Forms.Button buttonNula;
        private System.Windows.Forms.Button buttonPet;
        private System.Windows.Forms.Button buttonCtyri;
        private System.Windows.Forms.Button buttonCarka;
        private System.Windows.Forms.Button buttonTri;
        private System.Windows.Forms.Button buttonDva;
        private System.Windows.Forms.Button buttonJedna;
        private System.Windows.Forms.Button buttonSest;
        private System.Windows.Forms.Button buttonSedum;
        private System.Windows.Forms.Button buttonOsm;
        private System.Windows.Forms.Button buttonDevet;
        private System.Windows.Forms.Button buttonDeleni;
        private System.Windows.Forms.Button buttonRovnase;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonNasobeni;
        private System.Windows.Forms.Button buttonSmazatVstup;
        private System.Windows.Forms.Button buttonSmazatVse;
    }
}

