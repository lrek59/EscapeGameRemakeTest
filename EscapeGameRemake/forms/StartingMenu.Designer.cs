
namespace EscapeGameRemake
{
    partial class StartingMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nose_honk_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.credits_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nose_honk_button
            // 
            this.nose_honk_button.BackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.nose_honk_button.FlatAppearance.BorderSize = 0;
            this.nose_honk_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nose_honk_button.Location = new System.Drawing.Point(1021, 321);
            this.nose_honk_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nose_honk_button.Name = "nose_honk_button";
            this.nose_honk_button.Size = new System.Drawing.Size(149, 76);
            this.nose_honk_button.TabIndex = 2;
            this.nose_honk_button.UseVisualStyleBackColor = false;
            this.nose_honk_button.Click += new System.EventHandler(this.nose_honk_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Transparent;
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Location = new System.Drawing.Point(251, 333);
            this.play_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(131, 52);
            this.play_button.TabIndex = 3;
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            this.play_button.MouseHover += new System.EventHandler(this.play_button_MouseHover);
            // 
            // credits_button
            // 
            this.credits_button.BackColor = System.Drawing.Color.Transparent;
            this.credits_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credits_button.FlatAppearance.BorderSize = 0;
            this.credits_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.credits_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.credits_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits_button.Location = new System.Drawing.Point(251, 416);
            this.credits_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.credits_button.Name = "credits_button";
            this.credits_button.Size = new System.Drawing.Size(228, 52);
            this.credits_button.TabIndex = 4;
            this.credits_button.UseVisualStyleBackColor = false;
            this.credits_button.Click += new System.EventHandler(this.credits_button_Click);
            this.credits_button.MouseHover += new System.EventHandler(this.credits_button_MouseHover);
            // 
            // StartingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.StartingMenu_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.credits_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.nose_honk_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "StartingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.StartingMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nose_honk_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button credits_button;
    }
}

