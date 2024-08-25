
using System;

namespace WFCadastrarCliente
{
    partial class FormPrincipal
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
            mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            menuItemCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            menuItemListar = new System.Windows.Forms.ToolStripMenuItem();
            menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            pnlFundoPrincipal = new System.Windows.Forms.Panel();
            mnsMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            mnsMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemCadastrar, menuItemListar, menuItemSair });
            mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            mnsMenuPrincipal.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            mnsMenuPrincipal.Size = new System.Drawing.Size(571, 30);
            mnsMenuPrincipal.TabIndex = 0;
            // 
            // menuItemCadastrar
            // 
            menuItemCadastrar.Name = "menuItemCadastrar";
            menuItemCadastrar.Size = new System.Drawing.Size(86, 24);
            menuItemCadastrar.Text = "Cadastrar";
            menuItemCadastrar.Click += menuItemCadastrar_Click;
            // 
            // menuItemListar
            // 
            menuItemListar.Name = "menuItemListar";
            menuItemListar.Size = new System.Drawing.Size(58, 24);
            menuItemListar.Text = "Listar";
            menuItemListar.Click += menuItemListar_Click;
            // 
            // menuItemSair
            // 
            menuItemSair.Name = "menuItemSair";
            menuItemSair.Size = new System.Drawing.Size(48, 24);
            menuItemSair.Text = "Sair";
            menuItemSair.Click += menuItemSair_Click;
            // 
            // pnlFundoPrincipal
            // 
            pnlFundoPrincipal.BackgroundImage = Properties.Resources.peixe_cardume_oceano_mar;
            pnlFundoPrincipal.Location = new System.Drawing.Point(0, 36);
            pnlFundoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlFundoPrincipal.Name = "pnlFundoPrincipal";
            pnlFundoPrincipal.Size = new System.Drawing.Size(573, 353);
            pnlFundoPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(571, 389);
            Controls.Add(pnlFundoPrincipal);
            Controls.Add(mnsMenuPrincipal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = mnsMenuPrincipal;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FormPrincipal_Load;
            mnsMenuPrincipal.ResumeLayout(false);
            mnsMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemListar;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.Panel pnlFundoPrincipal;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}

